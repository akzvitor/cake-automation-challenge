sap.ui.define([
	"sap/ui/test/opaQunit",
	"./CriacaoCompra"
], (opaTest) => {
	"use strict";

	QUnit.module("CriacaoCompra");

	opaTest("Deveria filtrar o catálogo pelo nome da obra.", (Given, When, Then) => {
		Given.iStartMyApp({
			hash: "criacaoCompra"
		});

		When.naPaginaDeCriacaoCompra.euPreenchoOSearchField();

		Then.naPaginaDeCriacaoCompra.deveFiltrarOCatalogoPelaObraBuscada();
		Then.iTeardownMyApp();
	});

	opaTest("Deveria apresentar erro ao tentar salvar obra com dado inválido,", (Given, When, Then) => {
		Given.iStartMyApp({
			hash: "criacaoCompra"
		});

		When.naPaginaDeCriacaoCompra.euPreenchoOInputNomeComDadoInvalido("nomeFormInput", "2314");
		When.naPaginaDeCriacaoCompra.euClicoNoBotaoSalvar();

		Then.naPaginaDeCriacaoCompra.deveApresentarMensagemDeErroAoSalvarCompra();
		Then.iTeardownMyApp();
	});


	opaTest("Deveria salvar a obra quando todos os dados forem validados", (Given, When, Then) => {
		Given.iStartMyApp({
			hash: "criacaoCompra"
		});

		When.naPaginaDeCriacaoCompra.euPreenchoOInputNomeComDadoValido("nomeFormInput", "Paulo");
		When.naPaginaDeCriacaoCompra.euPreenchoOInputEmailComDadoValido("emailFormInput", "aasfae@km.com");
		When.naPaginaDeCriacaoCompra.euPreenchoOInputCpfComDadoValido("cpfFormInput", "69964405057");
		When.naPaginaDeCriacaoCompra.euPreenchoOInputTelefoneComDadoValido("telefoneFormInput", "65345445456");
		When.naPaginaDeCriacaoCompra.euSelecionoAoMenosUmaObraDoCatalogo();
		When.naPaginaDeCriacaoCompra.euClicoNoBotaoSalvar();

		Then.naPaginaDeCriacaoCompra.deveApresentarMensagemDeSucessoAoSalvarCompra();
		Then.iTeardownMyApp();
	});

	opaTest("Deveria apresentar inputs preenchidos com os dados da compra escolhida para edição", (Given, When, Then) => {
		Given.iStartMyApp({
			hash: "edicaoCompra/3"
		});

		Then.naPaginaDeCriacaoCompra.oInputNomeDeveConterOValor("Bruno");
		Then.naPaginaDeCriacaoCompra.oInputEmailDeveConterOValor("bruno@uol.com");
		Then.naPaginaDeCriacaoCompra.oInputCPFDeveConterOValor("602.582.600-50");
		Then.naPaginaDeCriacaoCompra.oInputTelefoneDeveConterOValor("(33) 53523-4235");

		Then.iTeardownMyApp();
	});

	opaTest("Deveria apresentar erro ao tentar editar obra com dado inválido", (Given, When, Then) => {
		Given.iStartMyApp({
			hash: "edicaoCompra/20"
		});

		When.naPaginaDeCriacaoCompra.euPreenchoOInputNomeComDadoInvalido("nomeFormInput", "2314");
		When.naPaginaDeCriacaoCompra.euClicoNoBotaoSalvar();

		Then.naPaginaDeCriacaoCompra.deveApresentarMensagemDeErroAoEditarCompra();
		Then.iTeardownMyApp();
	});


	opaTest("Deveria editar a obra quando todos os dados forem validados", (Given, When, Then) => {
		Given.iStartMyApp({
			hash: "edicaoCompra/20"
		});

		When.naPaginaDeCriacaoCompra.euPreenchoOInputNomeComDadoValido("nomeFormInput", "João");
		When.naPaginaDeCriacaoCompra.euPreenchoOInputEmailComDadoValido("emailFormInput", "joaogamer@hotmail.com");
		When.naPaginaDeCriacaoCompra.euPreenchoOInputCpfComDadoValido("cpfFormInput", "69964405057");
		When.naPaginaDeCriacaoCompra.euPreenchoOInputTelefoneComDadoValido("telefoneFormInput", "65345445456");
		When.naPaginaDeCriacaoCompra.euSelecionoAoMenosUmaObraDoCatalogo();
		When.naPaginaDeCriacaoCompra.euClicoNoBotaoSalvar();

		Then.naPaginaDeCriacaoCompra.deveApresentarMensagemDeSucessoAoEditarCompra();
		Then.iTeardownMyApp();
	});
});