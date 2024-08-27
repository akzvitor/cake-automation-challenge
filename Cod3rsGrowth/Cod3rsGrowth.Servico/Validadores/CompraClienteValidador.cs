using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Servico.Servicos;
using FluentValidation;
using LinqToDB;

namespace Cod3rsGrowth.Servico.Validadores
{
    public class CompraClienteValidador : AbstractValidator<CompraCliente>
    {
        private readonly IRepositorioCompraCliente _repositorioCompraCliente;
        private readonly ServicoObra _servicoObra;

        public CompraClienteValidador(IRepositorioCompraCliente repositorioCompraCliente, ServicoObra servicoObra)
        {
            _repositorioCompraCliente = repositorioCompraCliente;
            _servicoObra = servicoObra;
            
            RuleFor(cliente => cliente.Cpf)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("O CPF do cliente é obrigatório.")
                .Must(EhCpfValido)
                .WithMessage("O CPF informado é inválido.");

            RuleFor(cliente => cliente.Nome)
                .NotEmpty()
                .WithMessage("O nome do cliente deve ser informado.")
                .Matches("^[a-zA-Zà-úÀ-Ú-' ]*$")
                .WithMessage("O nome deve conter apenas letras, espaços ou símbolos como - e '.")
                .MaximumLength(100)
                .WithMessage("O nome do cliente pode ter até 100 caracteres.");

            RuleFor(cliente => cliente.Telefone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("O telefone do cliente é obrigatório.")
                .Matches(@"^\(?\d{2}\)?[\s-]?\d{4,5}[\s-]?\d{4}$")
                .WithMessage("O telefone deve ter apenas " + "números e símbolos e estar no formato correto " +
                                "(XX) XXXXX-XXXX ou (XX) XXXX-XXXX.");

            RuleFor(cliente => cliente.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("O e-mail do cliente é obrigatório.")
                .Matches("^[a-zA-Z0-9-_.@ ]*$")
                .WithMessage("O email deve conter apenas letras sem acento, números, espaços ou alguns símbolos, como - e _.")
                .EmailAddress()
                .WithMessage("Formato de e-mail inválido.");

            RuleFor(cliente => cliente.listaIdDosProdutos)
                .NotEmpty()
                .WithMessage("A compra deve conter pelo menos um produto.")
                .Must(ContemApenasProdutosValidos)
                .WithMessage("Alguns produtos na compra não estão cadastrados no sistema.");

            RuleFor(cliente => cliente.ValorCompra)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O valor da compra não pode ser negativo.");

            RuleFor(cliente => cliente.DataCompra)
                .NotEmpty()
                .GreaterThan(DateTime.MinValue)
                .WithMessage("A data da compra deve ser informada.");

            RuleSet("Editar", () =>
            {
                RuleFor(cliente => cliente)
                .Must(cliente => EhDataIgual(cliente.Id, cliente.DataCompra))
                .WithMessage("A data de uma compra concluída não pode ser alterada.");
            });
        }

        private static bool EhCpfValido(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
                return false;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        private bool EhDataIgual(int idCompra, DateTime dataCompraCliente)
        {
            return _repositorioCompraCliente
                .ObterPorId(idCompra)
                .DataCompra == dataCompraCliente;
        }

        private bool ContemApenasProdutosValidos(List<int> listaDeIdProdutosDaRequisicao)
        {
            List<int> listaDeIdObrasDoBanco = _servicoObra.ObterTodos().Select(obj => obj.Id).ToList();

            var listaDeProdutosInvalidos = listaDeIdProdutosDaRequisicao.Except(listaDeIdObrasDoBanco).ToList();

            if (listaDeProdutosInvalidos.Any())
            {
                return false;
            }

            return true;
        }
    }
}