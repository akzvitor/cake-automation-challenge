sap.ui.define([
    "ui5/coders/app/common/BaseController",
    "ui5/coders/model/formatter"

], (BaseController, formatter) => {
    "use strict";

    const ROTA_LISTAGEM = "listagem"
    const API_COMPRAS_URL = "http://localhost:5070/api/Compras";
    const MODELO_COMPRAS = "restCompras";
    const ID_NOME_FILTRO_INPUT = "nomeFiltroInput";
    const ID_CPF_FILTRO_INPUT = "cpfFiltroInput";
    const ID_DATERANGE_FILTRO_INPUT = "dateRangeFiltroInput";

    return BaseController.extend("ui5.coders.app.CompraCliente.Listagem", {
        formatter: formatter,

        onInit() {
            this.aoCoincidirRota(ROTA_LISTAGEM, API_COMPRAS_URL, MODELO_COMPRAS);
        },

        aoAlterarInputFiltro(oEvent) {
            this.processarAcao(() => {
                let urlFiltro = "http://localhost:5070/api/Compras?";
                const inputNome = this.oView.byId(ID_NOME_FILTRO_INPUT).getValue();
                const inputCpf = this.oView.byId(ID_CPF_FILTRO_INPUT).getValue();
                const inputDateRange = this.oView.byId(ID_DATERANGE_FILTRO_INPUT).getValue();
                const objData = this.aoSelecionarData(oEvent);
                const dataInicial = this.formatarDataParaApi(objData.di);
                const dataFinal = this.formatarDataParaApi(objData.df);

                if (inputNome) { urlFiltro += "NomeCliente=" + inputNome + "&"; }

                if (inputCpf) { urlFiltro += "Cpf=" + inputCpf + "&"; }

                if (inputDateRange) { urlFiltro += "DataInicial=" + dataInicial + "&DataFinal=" + dataFinal; }

                this.inicializarDados(urlFiltro, MODELO_COMPRAS);
            });
        },

        aoSelecionarData(oEvent) {
            return this.processarAcao(() => {
                let dataInicial = oEvent.getParameter("from");
                let dataFinal = oEvent.getParameter("to");
                let obj = { di: Number, df: Number };

                obj.di = dataInicial;
                obj.df = dataFinal;

                return obj;
            });
        },

        aoClicarNoBotaoAdicionar() {
            this.processarAcao(() => {
                const oRouter = this.getOwnerComponent().getRouter();
                oRouter.navTo("criacaoCompra");
            });
        },

        aoSelecionarCompra(oEvent) {
            this.processarAcao(() => {
                const oItem = oEvent.getSource();
                const oRouter = this.getOwnerComponent().getRouter();
                oRouter.navTo("detalhes", {
                    idCompra: window.encodeURIComponent(oItem.getBindingContext(MODELO_COMPRAS).getProperty("id"))
                })
            });
        }
    });
});