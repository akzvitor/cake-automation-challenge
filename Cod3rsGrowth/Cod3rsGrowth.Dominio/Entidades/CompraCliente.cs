using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Entidades
{
    [Table("ComprasCliente")]
    public class CompraCliente
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column("Cpf"), NotNull]
        public string Cpf { get; set; }

        [Column("Nome"), NotNull]
        public string Nome { get; set; }

        [Column("Telefone"), NotNull]
        public string Telefone { get; set; }

        [Column("Email"), NotNull]
        public string Email { get; set; }

        [Column("Valor"), NotNull]
        public decimal ValorCompra { get; set; }

        [Column("DataCompra"), NotNull]
        public DateTime DataCompra { get; set; }
        public List<int> listaIdDosProdutos { get; set; }

    }
}
