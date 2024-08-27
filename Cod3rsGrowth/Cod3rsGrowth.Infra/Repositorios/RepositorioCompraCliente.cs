using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Infra.ConexaoDeDados;
using LinqToDB;
using LinqToDB.Data;

namespace Cod3rsGrowth.Infra.Repositorios
{
    public class RepositorioCompraCliente : IRepositorioCompraCliente
    {
        private readonly DbCodersGrowth _db;

        public RepositorioCompraCliente(DbCodersGrowth conexaoComBancoDeDados) 
        {
            _db = conexaoComBancoDeDados;
        }

        public List<CompraCliente> ObterTodos(FiltroCompraCliente? filtroCompra = null)
        {
            var query = Filtrar(filtroCompra);
            var comprasFiltradas = query.ToList();

            foreach (var item in comprasFiltradas)
            {
                item.listaIdDosProdutos = ObterProdutosVinculados(item.Id);
            }

            return comprasFiltradas;
        }

        public CompraCliente ObterPorId(int id)
        {
            var compraRequisitada = _db.ComprasCliente.FirstOrDefault(c => c.Id == id)
                ?? throw new Exception("Compra não encontrada.");

            compraRequisitada.listaIdDosProdutos = ObterProdutosVinculados(id);

            return compraRequisitada;
        }

        public CompraCliente Criar(CompraCliente compraCliente)
        {
            compraCliente.Id = _db.InsertWithInt32Identity(compraCliente);
            AdicionarProdutos(compraCliente.Id, compraCliente.listaIdDosProdutos);

            return compraCliente;
        }

        public CompraCliente Editar(CompraCliente compra)
        {
            var compraNoBanco = ObterPorId(compra.Id);

            var produtosAnteriores = ObterProdutosVinculados(compra.Id);
            var produtosAtualizados = compra.listaIdDosProdutos;

            var hashSetProdutosAnteriores = new HashSet<int>(produtosAnteriores);
            var hashSetProdutosAtualizados = new HashSet<int>(produtosAtualizados);

            List<int> produtosParaRemover = new();
            List<int> produtosParaAdicionar = new();

            produtosAnteriores.ForEach(item =>
            {
                if (!hashSetProdutosAtualizados.Contains(item))
                {
                    produtosParaRemover.Add(item);
                }
            });

            produtosAtualizados.ForEach(item =>
            {
                if (!hashSetProdutosAnteriores.Contains(item))
                {
                    produtosParaAdicionar.Add(item);
                }
            });

            try
            {
                _db.Update(compra);
                RemoverProdutos(compra.Id, produtosParaRemover);
                AdicionarProdutos(compra.Id, produtosParaAdicionar);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível editar a compra.");
            }
            
            return compra;
        }

        public void Remover(int id)
        {
            var compraNoBanco = _db.ComprasCliente.FirstOrDefault(c => c.Id == id)
                ?? throw new Exception("Compra não encontrada.");

            try
            {
                _db.ComprasCliente
                    .Where(c => c.Id == id)
                    .Delete();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível remover a compra.");
            }
        }

        private void AdicionarProdutos(int compraId, List<int> idProdutos)
        {
            idProdutos.ForEach(id =>
            {
                _db.Execute(
                    "INSERT INTO ComprasObras (CompraId, ObraId) VALUES (@compraId, @item)",
                    new DataParameter("@compraId", compraId),
                    new DataParameter("@item", id)
                );
            });
        }

        private void RemoverProdutos(int compraId, List<int> idsDosProdutos)
        {
            idsDosProdutos.ForEach(obraId =>
            {
                _db.Execute(
                    $"DELETE FROM ComprasObras WHERE CompraId = @compraId AND ObraId = @obraId",
                    new DataParameter("@compraId", compraId),
                    new DataParameter("@obraId", obraId)
                );
            });
        }

        public List<int> ObterProdutosVinculados(int compraId)
        {
            List<int> produtosVinculados = _db.Query<int>($"SELECT ObraId FROM ComprasObras " +
                                                          $"WHERE CompraId = @compraId", new { compraId }).ToList();

            return produtosVinculados;
        }

        public IQueryable<CompraCliente> Filtrar(FiltroCompraCliente filtroCompra)
        {
            IQueryable<CompraCliente> compras = _db.ComprasCliente;

            if (filtroCompra == null)
            {
                return compras;
            }

            if (!string.IsNullOrEmpty(filtroCompra.NomeCliente))
            {
                compras = compras.Where(c => c.Nome.Contains(filtroCompra.NomeCliente));
            }

            if (!string.IsNullOrEmpty(filtroCompra.Cpf))
            {
                compras = compras.Where(c => c.Cpf.Trim().Replace(".", "").Replace("-", "").Contains(filtroCompra.Cpf.Trim().Replace(".", "").Replace("-", "")));
            }

            if ((filtroCompra.DataInicial.HasValue && filtroCompra.DataInicial != DateTime.MinValue) && (filtroCompra.DataFinal.HasValue && filtroCompra.DataFinal != DateTime.MaxValue))
            {
                compras = compras.Where(c => (c.DataCompra >= filtroCompra.DataInicial.Value) && (c.DataCompra <= filtroCompra.DataFinal.Value));
            }
            
            return compras;
        }
    }
}
