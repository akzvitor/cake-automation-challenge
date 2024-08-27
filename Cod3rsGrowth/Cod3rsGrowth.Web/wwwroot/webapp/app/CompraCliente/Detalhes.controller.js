sap.ui.define([
    "ui5/coders/app/common/BaseController",
    "sap/ui/model/json/JSONModel",

    
], (BaseController, JSONModel) => {
    "use strict";

    const ROTA_DETALHES = "detalhes";
    const API_COMPRAS_URL = "http://localhost:5070/api/Compras";
    const MODELO_COMPRAS = "restCompras";
    const MODELO_OBRAS = "restObras";
    const API_OBRAS_URL = "http://localhost:5070/api/Obras/Compra";


    return BaseController.extend("ui5.coders.app.CompraCliente.Detalhes", {
        onInit() {
			 this._aoCoincidirRota(ROTA_DETALHES);
		},

        _aoCoincidirRota(rota) {
            this.processarAcao(() => {
	    		const oRouter = this.getOwnerComponent().getRouter();
                oRouter.getRoute(rota).attachPatternMatched(this._inicializarDadosDaCompraSelecionada, this);
	    	});
        },

        _inicializarDadosDaCompraSelecionada(oEvent) {
			let sucesso = true;
			fetch(API_COMPRAS_URL + "/" + window.decodeURIComponent(oEvent.getParameter("arguments").idCompra))
				.then((res) => {
					if (!res.ok)
						sucesso = false;
					return res.json();
				})
				.then((data) => {
					sucesso ?  this.getView().setModel(new JSONModel(data), MODELO_COMPRAS)
					: this.capturarErroApi(data);
				})
				.catch((err) => console.error(err));

			fetch(API_OBRAS_URL + "/" + window.decodeURIComponent(oEvent.getParameter("arguments").idCompra))
				.then((res) => {
					if (!res.ok)
						sucesso = false;
					return res.json();
				})
				.then((data) => {
					sucesso ?  this.getView().setModel(new JSONModel(data), MODELO_OBRAS)
					: this.capturarErroApi(data);
				})
				.catch((err) => console.error(err));
		},

		aoClicarNoBotaoEditar(oEvent) {
            this.processarAcao(() => {
				const oItem = oEvent.getSource();
                const oRouter = this.getOwnerComponent().getRouter();
                oRouter.navTo("edicaoCompra" , {
					idCompra: window.encodeURIComponent(oItem.getBindingContext(MODELO_COMPRAS).getProperty("id"))
				});
            });
        }
    });
});