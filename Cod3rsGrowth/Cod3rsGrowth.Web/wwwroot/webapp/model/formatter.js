sap.ui.define([
    "sap/ui/core/format/NumberFormat",
    "sap/ui/core/format/DateFormat"
], (NumberFormat, DateFormat) => {
    "use strict";

    return {
        formatarValor(valor) {
            let oCurrencyFormat = NumberFormat.getCurrencyInstance({
                currencyCode: false
            });

            return oCurrencyFormat.format(valor, "BRL");
        },

        formatarData(data) {
            if (data === null || data === undefined) { return data; }

            let oDateTimeFormat = DateFormat.getDateTimeInstance({
                format: "yMMMd"
            });

            return oDateTimeFormat.format(new Date(data));
        },

        async formatarCpf(cpf) {
            if (cpf === null || cpf === undefined) { return cpf; }

            return cpf.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, "$1.$2.$3-$4");
        },

        async formatarTelefone(telefone) {
            if (telefone === null || telefone === undefined) { return telefone; }

            telefone = telefone.replace(/\D/g, '');
            telefone = telefone.replace(/(\d{2})(\d)/, "($1) $2");
            telefone = telefone.replace(/(\d)(\d{4})$/, "$1-$2");
            return telefone;
        },

        formatarFormato(formato) {
            const oResourceBundle = this.getOwnerComponent().getModel("i18n").getResourceBundle();

            switch (formato) {
                case 0:
                    return oResourceBundle.getText("Formato.manga");
                case 1:
                    return oResourceBundle.getText("Formato.manhwa");
                case 2:
                    return oResourceBundle.getText("Formato.manhua");
                case 3:
                    return oResourceBundle.getText("Formato.webnovel");
            }
        }
    };
});