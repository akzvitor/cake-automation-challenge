sap.ui.define([
	"sap/ui/test/opaQunit",
	"./Listagem",
	"./CriacaoCompra",
	"./Detalhes"
], (opaTest) => {
	"use strict";

	QUnit.module("Listagem");

	opaTest("Deveria ver a página de criação ao clicar no botão adicionar.", (Given, When, Then) => {
		Given.iStartMyApp();

		When.naPaginaDeListagem.euClicoNoBotaoAdicionar();

		Then.naPaginaDeCriacaoCompra.aPaginaDeveMudarParaCriacaoCompra();
	});

	opaTest("Deveria voltar para a página de Listagem.", (Given, When, Then) => {
		When.naPaginaDeCriacaoCompra.euClicoNoBotaoNavBack();

		Then.naPaginaDeListagem.aPaginaDeveMudarParaListagem();
		Then.iTeardownMyApp();
	});

	opaTest("Deveria ver a página de detalhes ao clicar em algum item da tabela.", (Given, When, Then) => {
		Given.iStartMyApp();

		When.naPaginaDeListagem.euClicoEmUmItemDaTabela();

		Then.naPaginaDeDetalhes.aPaginaDeveMudarParaDetalhes();
	});

	opaTest("Deveria voltar para a página de Listagem.", (Given, When, Then) => {
		When.naPaginaDeDetalhes.euClicoNoBotaoNavBack();

		Then.naPaginaDeListagem.aPaginaDeveMudarParaListagem();
		Then.iTeardownMyApp();
	});


	opaTest("Deveria filtrar os dados da tabela por nome do cliente e exibir a tabela com os dados filtrados.", (Given, When, Then) => {
		Given.iStartMyApp();

		When.naPaginaDeListagem.euPreenchoOInputNome();

		Then.naPaginaDeListagem.aTabelaDeveSerFiltradaDeAcordoComFiltroNome();
		Then.iTeardownMyApp();
	});

	opaTest("Deveria filtrar os dados da tabela por CPF e exibir a tabela com os dados filtrados.", (Given, When, Then) => {
		Given.iStartMyApp();

		When.naPaginaDeListagem.euPreenchoOInputCPF();

		Then.naPaginaDeListagem.aTabelaDeveSerFiltradaDeAcordoComFiltroCPF();
		Then.iTeardownMyApp();
	});

	opaTest("Deveria filtrar os dados da tabela pela data e exibir a tabela com os dados filtrados.", (Given, When, Then) => {
		Given.iStartMyApp();

		When.naPaginaDeListagem.euSelecionoAData();

		Then.naPaginaDeListagem.aTabelaDeveSerFiltradaDeAcordoComDataNoFiltroData();
		Then.iTeardownMyApp();
	});

	opaTest("Deveria filtrar os dados da tabela pelo periodo e exibir a tabela com os dados filtrados.", (Given, When, Then) => {
		Given.iStartMyApp();

		When.naPaginaDeListagem.euSelecionoOPeriodo();

		Then.naPaginaDeListagem.aTabelaDeveSerFiltradaDeAcordoComRangeNoFiltroData();
		Then.iTeardownMyApp();
	});
});