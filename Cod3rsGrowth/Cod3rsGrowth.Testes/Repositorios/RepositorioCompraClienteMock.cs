using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Infra.Repositorios;

namespace Cod3rsGrowth.Testes.Repositorios
{
    public class RepositorioCompraClienteMock : IRepositorioCompraCliente
    {
        private List<CompraCliente> _listaCompraCliente = ListaSingleton.Instancia.ListaCompraCliente;
        private int _compraClienteId = 100;

        public List<CompraCliente> ObterTodos(FiltroCompraCliente? filtro = null)
        {
            return _listaCompraCliente;
        }

        public CompraCliente ObterPorId(int id)
        {
            var compraRequisitada = _listaCompraCliente.Find(compra => compra.Id == id)
                ?? throw new Exception($"O ID informado ({id}) é inválido. Compra não encontrada.");

            return compraRequisitada;
        }

        public CompraCliente Criar(CompraCliente compraCliente)
        {
            compraCliente.Id = _compraClienteId;
            _compraClienteId++;
            _listaCompraCliente.Add(compraCliente);

            return compraCliente;
        }

        public CompraCliente Editar(CompraCliente compraCliente)
        {
            var compraNoBanco = ObterPorId(compraCliente.Id);

            compraNoBanco.Cpf = compraCliente.Cpf;
            compraNoBanco.Nome = compraCliente.Nome;
            compraNoBanco.Telefone = compraCliente.Telefone;
            compraNoBanco.Email = compraCliente.Email;
            compraNoBanco.listaIdDosProdutos = compraCliente.listaIdDosProdutos;
            compraNoBanco.ValorCompra = compraCliente.ValorCompra;
            compraNoBanco.DataCompra = compraCliente.DataCompra;

            return compraNoBanco;
        }

        public void Remover(int id)
        {
            var compra = ObterPorId(id);

            _listaCompraCliente.Remove(compra);
        }

        public List<int> ObterProdutosVinculados(int compraId)
        {
            var compraSelecionada = ObterPorId(compraId);
            var produtosVinculados = compraSelecionada.listaIdDosProdutos;

            return produtosVinculados;
        }
    }
}
