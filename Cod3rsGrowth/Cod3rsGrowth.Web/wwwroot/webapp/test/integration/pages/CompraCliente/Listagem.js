sap.ui.define([
    "sap/ui/test/Opa5",
    "sap/ui/test/actions/EnterText",
    'sap/ui/test/matchers/AggregationLengthEquals',
    'sap/ui/test/matchers/PropertyStrictEquals',
    "sap/ui/test/matchers/AggregationFilled",
    'sap/ui/test/actions/Press'
], (Opa5, EnterText, AggregationLengthEquals, PropertyStrictEquals, AggregationFilled, Press) => {
    "use strict";

    const NOME_DA_VIEW = "CompraCliente.Listagem";
    const NOME_DO_MODELO = "restCompras";
    const ID_BOTAO_ADICIONAR = "botaoAdicionar";
    const ID_INPUT_NOME = "nomeFiltroInput";
    const ID_INPUT_CPF = "cpfFiltroInput";
    const ID_DATERANGE = "dateRangeFiltroInput";
    const ID_TABELA = "tabelaCompras";
    const STRING_INSERIDO_INPUT_NOME = "Bruno";
    const STRING_INSERIDO_INPUT_CPF = "60258260050";
    const STRING_INSERIDO_INPUT_DATA_UNICA = "19/08/2024";
    const STRING_INSERIDO_INPUT_DATA_RANGE = "10/08/2022 - 19/08/2024"
    const TAG_ITENS_TABELA = "items";
    const MENSAGEM_SUCESSO_BUSCAR_ITEM = "A tabela contém o item esperado.";
    const MENSAGEM_ERRO_CARREGAR_TABELA = "Ocorreu um erro ao carregar a tabela ou filtrar os dados.";

    Opa5.createPageObjects({
        naPaginaDeListagem: {
            actions: {
                euClicoNoBotaoAdicionar() {
                    return this.waitFor({
                        id: ID_BOTAO_ADICIONAR,
                        viewName: NOME_DA_VIEW,
                        actions: new Press(),
                        errorMessage: "Botão adicionar não encontrado.",
                        success: function() {
                            return new Promise(resolve => setTimeout(resolve, 1000)); 
                        }
                    });
                },

                euClicoEmUmItemDaTabela() {
                    return this.waitFor({
                        viewName: NOME_DA_VIEW,
                        controlType: "sap.m.Text",
                        matchers: [
                            new PropertyStrictEquals({
                                name: "text",
                                value: "Bruno"
                            })
                        ],
                        actions: new Press(),
                        errorMessage: "Item não encontrado.",
                        success: function() {
                            return new Promise(resolve => setTimeout(resolve, 1000)); 
                        }
                    });
                },

                euPreenchoOInputNome() {
                    return this.waitFor({
                        id: ID_INPUT_NOME,
                        viewName: NOME_DA_VIEW,
                        actions: new EnterText({
                             text: STRING_INSERIDO_INPUT_NOME 
                        }),
                        errorMessage: "Input de filtro Nome não encontrado.",
                        success: function() {
                            return new Promise(resolve => setTimeout(resolve, 1000)); 
                        }
                    });
                },

                euPreenchoOInputCPF() {
                    return this.waitFor({
                        id: ID_INPUT_CPF,
                        viewName: NOME_DA_VIEW,
                        actions: new EnterText({
                            text: STRING_INSERIDO_INPUT_CPF
                        }),
                        errorMessage: "Input de filtro CPF não encontrado.",
                        success: function() {
                            return new Promise(resolve => setTimeout(resolve, 1000)); 
                        }
                    });
                },

                euSelecionoAData() {
                    return this.waitFor({
                        id: ID_DATERANGE,
                        viewName: NOME_DA_VIEW,
                        actions: new EnterText({
                            text: STRING_INSERIDO_INPUT_DATA_UNICA
                        }),
                        errorMessage: "Input de filtro Data Única não encontrado.",
                        success: function() {
                            return new Promise(resolve => setTimeout(resolve, 1000)); 
                        }
                    });
                },

                euSelecionoOPeriodo() {
                    return this.waitFor({
                        id: ID_DATERANGE,
                        viewName: NOME_DA_VIEW,
                        actions: new EnterText({
                            text: STRING_INSERIDO_INPUT_DATA_RANGE
                        }),
                        errorMessage: "Input de filtro Data com Range não encontrado.",
                        success: function() {
                            return new Promise(resolve => setTimeout(resolve, 1000)); 
                        }
                    });
                }
            },

            assertions: {
                aPaginaDeveMudarParaListagem() {
                    return this.waitFor({
                        id: ID_TABELA,
                        viewName: NOME_DA_VIEW,
                        success: function () {
                            Opa5.assert.ok(true, "A tabela está sendo exibida.");
                        },
                        errorMessage: "Não é possível visualizar a tabela."
                    });
                },

                aTabelaDeveSerFiltradaDeAcordoComFiltroNome() {
                    const propriedadeTestada = "nome";

                    return this.waitFor({
                        id: ID_TABELA,
                        viewName: NOME_DA_VIEW,
                        matchers: new AggregationFilled({
                            name: TAG_ITENS_TABELA
                        }),
                        success: function (oTable) {
                            const itensTabela = oTable.getItems();
                            let resultado = true;
                    
                            itensTabela.map((item) => {
                                let nomeBuscado = item.getBindingContext(NOME_DO_MODELO).getProperty(propriedadeTestada);

                                if (!nomeBuscado.includes(STRING_INSERIDO_INPUT_NOME)) 
                                    resultado = false;
                            });

                            Opa5.assert.ok(resultado, MENSAGEM_SUCESSO_BUSCAR_ITEM);
                        },
                        errorMessage: MENSAGEM_ERRO_CARREGAR_TABELA
                    });
                },

                aTabelaDeveSerFiltradaDeAcordoComFiltroCPF() {
                    const propriedadeTestada = "cpf";

                    return this.waitFor({
                        id: ID_TABELA,
                        viewName: NOME_DA_VIEW,
                        matchers: new AggregationFilled({
                            name: TAG_ITENS_TABELA
                        }),
                        success: function (oTable) {
                            const itensTabela = oTable.getItems();
                            let resultado = true;

                            itensTabela.map((item) => {
                                let cpfBuscado = item.getBindingContext(NOME_DO_MODELO).getProperty(propriedadeTestada);

                                if (cpfBuscado !== STRING_INSERIDO_INPUT_CPF)
                                    resultado = false;
                            })

                            Opa5.assert.ok(resultado, MENSAGEM_SUCESSO_BUSCAR_ITEM);
                        },
                        errorMessage: MENSAGEM_ERRO_CARREGAR_TABELA
                    });
                },

                aTabelaDeveSerFiltradaDeAcordoComDataNoFiltroData() {
                    return this.waitFor({
                        id: ID_TABELA,
                        viewName: NOME_DA_VIEW,
                        matchers: new AggregationLengthEquals({
                            name: TAG_ITENS_TABELA,
                            length: 2
                        }),
                        success: function () {
							Opa5.assert.ok(true, "A tabela contém os 2 itens correspondentes a data filtrada.");
						},
                        errorMessage: MENSAGEM_ERRO_CARREGAR_TABELA
                    });
                },

                aTabelaDeveSerFiltradaDeAcordoComRangeNoFiltroData() {
                    return this.waitFor({
                        id: ID_TABELA,
                        viewName: NOME_DA_VIEW,
                        matchers: new AggregationLengthEquals({
                            name: TAG_ITENS_TABELA,
                            length: 2
                        }),
                        success: function () {
							Opa5.assert.ok(true, "A tabela contém os 9 itens correspondentes ao periodo filtrado.");
						},
                        errorMessage: MENSAGEM_ERRO_CARREGAR_TABELA
                    });
                },
            }
        }
    });
});