using Cod3rsGrowth.Dominio.Entidades;
using LinqToDB;
using LinqToDB.Data;

namespace Cod3rsGrowth.Infra.ConexaoDeDados
{
    public class DbCodersGrowth : DataConnection
    {
        public DbCodersGrowth(string stringDeConexao) : base("SqlServer", stringDeConexao) { }

        public ITable<CompraCliente> ComprasCliente => this.GetTable<CompraCliente>();
        public ITable<Obra>          Obras          => this.GetTable<Obra>();
    }
}
