sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/core/routing/History",
	"sap/ui/model/json/JSONModel",
	"sap/ui/core/UIComponent",
	"ui5/coders/model/formatter",
	"sap/m/MessageBox",

], function (Controller, History, JSONModel, UIComponent, formatter, MessageBox) {
	"use strict";

	return Controller.extend("ui5.coders.app.common.BaseController", {
		formatter: formatter,

		getRouter() {
			return UIComponent.getRouterFor(this);
		},

		processarAcao(action) {
			try {
				const resultado = action();
				return resultado;
			} catch (error) {
				MessageBox.error(error.message);
			}
		},

		aoCoincidirRota(rota, urlDaApi, nomeDoModelo) {
			this.processarAcao(() => {
				const oRouter = this.getOwnerComponent().getRouter();
				oRouter.getRoute(rota).attachPatternMatched(() => {
					this.inicializarDados(urlDaApi, nomeDoModelo);
				}, this);
			});
		},

		onNavBack() {
			var history, previousHash;

			history = History.getInstance();
			previousHash = history.getPreviousHash();

			if (previousHash !== undefined) {
				window.history.go(-1);
			} else {
				this.getRouter().navTo("listagem", {}, true);
			}
		},

		inicializarDados(urlDaApi, nomeDoModelo) {
			let sucesso = true;
			fetch(urlDaApi)
				.then((res) => {
					if (!res.ok)
						sucesso = false;
					return res.json();
				})
				.then((data) => {
					sucesso ?  this.getView().setModel(new JSONModel(data), nomeDoModelo)
					: this.capturarErroApi(data);
				})
				.catch((err) => console.error(err));
		},

		capturarErroApi(erroRfc) {
			const mensagemErroPrincipal = erroRfc.Extensions.Erros.join(', ');
			const mensagemErroCompleta = `<p><strong>Status:</strong> ${erroRfc.Status}</p>` +
				`<p><strong>Detalhes:</strong><br /> ${erroRfc.Detail}</p>` +
				"<p>Para mais ajuda acesse <a href='//www.sap.com' target='_top'>aqui</a>.";

			MessageBox.error(mensagemErroPrincipal, {
				title: "Erro",
				details: mensagemErroCompleta,
				styleClass: "sapUiResponsivePadding--header sapUiResponsivePadding--content sapUiResponsivePadding--footer",
				dependentOn: this.getView()
			});
		},

		formatarDataParaApi(data) {
			if (data === null || data === undefined) { return data; }

			let oDate = new Date(data);
			return oDate.toISOString();
		}
	});
});
