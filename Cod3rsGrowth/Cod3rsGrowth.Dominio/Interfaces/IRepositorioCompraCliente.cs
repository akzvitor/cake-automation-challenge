using Cod3rsGrowth.Dominio.Entidades;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IRepositorioCompraCliente : IRepositorio<CompraCliente, FiltroCompraCliente>
    {
        List<int> ObterProdutosVinculados(int compraId);
    }
}
