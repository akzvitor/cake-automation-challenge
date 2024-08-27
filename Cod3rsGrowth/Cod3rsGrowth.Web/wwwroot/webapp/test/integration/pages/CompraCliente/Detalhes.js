sap.ui.define([
    "sap/ui/test/Opa5",
    "sap/ui/test/matchers/Properties",  
    "sap/ui/test/actions/Press"  

], (Opa5, Properties, Press) => {
    "use strict";

    const NOME_DA_VIEW = "CompraCliente.Detalhes";
    const ID_PAGINA_DETALHES = "paginaDetalhes";

    Opa5.createPageObjects({
        naPaginaDeDetalhes: {
            actions: {
                euClicoNoBotaoNavBack() {
                    return this.waitFor({
                        id:ID_PAGINA_DETALHES,
                        viewName: NOME_DA_VIEW,
                        actions: new Press(),
                        errorMessage: "Botão de navback não encontrado"
                    });
                },
                
                euClicoNoBotaoEditar() {
                    return this.waitFor({
                        id:"botaoEditar",
                        viewName: NOME_DA_VIEW,
                        actions: new Press(),
                        errorMessage: "Botão Editar não encontrado"
                    });
                }
            },

            assertions: {
                aPaginaDeveMudarParaDetalhes() {
                    return this.waitFor({
                        success: function () {
                            return this.waitFor({
                                id:"paginaDetalhes",
                                viewName: NOME_DA_VIEW,
                                matchers: new Properties ({
                                    title: "Detalhes"
                                }),
                                success: function () {
                                    Opa5.assert.ok(true, "Está na página de Detalhes");
                                },
                                errorMessage: "Não está mostrando o título Detalhes"
                            });
                        }
                    });
                },

                oObjectListItemComIntroNomeDevePossuirOValor(valor) {
                    return this.waitFor({
                        viewName: NOME_DA_VIEW,
                        controlType: "sap.m.ObjectListItem",
                        matchers: {
                            i18NText: {
                                propertyName: "intro",
                                key: "Compra.Nome"
                            },
                            properties: {
                                title: valor
                            }
                        },
                        success: function () {
							Opa5.assert.ok(true, `O objeto de intro Nome possui o valor ${valor}.`);
						},
                        errorMessage: `O objeto de intro Nome não possui o valor esperado (${valor}).`
                    });
                },

                oObjectListItemComIntroEmailDevePossuirOValor(valor) {
                    return this.waitFor({
                        viewName: NOME_DA_VIEW,
                        controlType: "sap.m.ObjectListItem",
                        matchers: {
                            i18NText: {
                                propertyName: "intro",
                                key: "Compra.Email"
                            },
                            properties: {
                                title: valor
                            }
                        },
                        success: function () {
							Opa5.assert.ok(true, `O objeto de intro E-mail possui o valor ${valor}.`);
						},
                        errorMessage: `O objeto de intro E-mail não possui o valor esperado (${valor}).`
                    });
                },

                oObjectListItemComIntroCpfDevePossuirOValor(valor) {
                    return this.waitFor({
                        viewName: NOME_DA_VIEW,
                        controlType: "sap.m.ObjectListItem",
                        matchers: {
                            i18NText: {
                                propertyName: "intro",
                                key: "Compra.Cpf"
                            },
                            properties: {
                                title: valor
                            }
                        },
                        success: function () {
							Opa5.assert.ok(true, `O objeto de intro CPF possui o valor ${valor}.`);
						},
                        errorMessage: `O objeto de intro CPF não possui o valor esperado (${valor}).`
                    });
                },

                oObjectListItemComIntroTelefoneDevePossuirOValor(valor) {
                    return this.waitFor({
                        viewName: NOME_DA_VIEW,
                        controlType: "sap.m.ObjectListItem",
                        matchers: {
                            i18NText: {
                                propertyName: "intro",
                                key: "Compra.Telefone"
                            },
                            properties: {
                                title: valor
                            }
                        },
                        success: function () {
							Opa5.assert.ok(true, `O objeto de intro Telefone possui o valor ${valor}.`);
						},
                        errorMessage: `O objeto de intro Telefone não possui o valor esperado (${valor}).`
                    });
                },

                oObjectListItemComIntroDataCompraDevePossuirOValor(valor) {
                    return this.waitFor({
                        viewName: NOME_DA_VIEW,
                        controlType: "sap.m.ObjectListItem",
                        matchers: {
                            i18NText: {
                                propertyName: "intro",
                                key: "Detalhes.DataCompra"
                            },
                            properties: {
                                title: valor
                            }
                        },
                        success: function () {
							Opa5.assert.ok(true, `O objeto de intro Data da compra possui o valor ${valor}.`);
						},
                        errorMessage: `O objeto de intro Data da compra não possui o valor esperado (${valor}).`
                    });
                },

                oObjectListItemComIntroValorTotalDevePossuirOValor(valor) {
                    return this.waitFor({
                        viewName: NOME_DA_VIEW,
                        controlType: "sap.m.ObjectListItem",
                        matchers: {
                            i18NText: {
                                propertyName: "intro",
                                key: "Detalhes.ValorTotal"
                            },
                            properties: {
                                title: valor
                            }
                        },
                        success: function () {
							Opa5.assert.ok(true, `O objeto de intro Valor total possui o valor ${valor}.`);
						},
                        errorMessage: `O objeto de intro Valor total não possui o valor esperado (${valor}).`
                    });
                }
            }
        }
    });
});