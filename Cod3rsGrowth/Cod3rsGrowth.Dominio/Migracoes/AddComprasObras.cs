using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migracoes
{
    [Migration(20240617082400)]
    public class AddComprasObras : Migration
    {
        public override void Up()
        {
            Create.Table("ComprasObras")
                .WithColumn("CompraId").AsInt32().ForeignKey("ComprasCliente", "Id")
                .WithColumn("ObraId").AsInt32().ForeignKey("Obras", "Id").Nullable();
        }

        public override void Down()
        {
            Delete.Table("ComprasObras");
        }
    }
}
