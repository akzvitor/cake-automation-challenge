using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migracoes
{
    [Migration(20240617082200)]
    public class AddComprasCliente : Migration
    {
        public override void Up()
        {
            Create.Table("ComprasCliente")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Cpf").AsString()
                .WithColumn("Nome").AsString(100)
                .WithColumn("Telefone").AsString()
                .WithColumn("Email").AsString()
                .WithColumn("Valor").AsDecimal(20, 2)
                .WithColumn("DataCompra").AsDateTime();
        }

        public override void Down()
        {
            Delete.Table("ComprasCliente");
        }
    }
}
