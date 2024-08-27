using FluentMigrator;
using System.Data;

namespace Cod3rsGrowth.Dominio.Migracoes
{
    [Migration(20240617082500)]
    public class AddChavesEstrangeiras : Migration
    {
        public override void Up()
        {
            Create.ForeignKey("FK_GenerosObras_ObraId")
                .FromTable("GenerosObras").ForeignColumn("ObraId")
                .ToTable("Obras").PrimaryColumn("Id")
                .OnDeleteOrUpdate(Rule.Cascade);

            Create.ForeignKey("FK_ComprasObras_CompraId")
                .FromTable("ComprasObras").ForeignColumn("CompraId")
                .ToTable("ComprasCliente").PrimaryColumn("Id")
                .OnDeleteOrUpdate(Rule.Cascade);

            Create.ForeignKey("FK_ComprasObras_ObraId")
                .FromTable("ComprasObras").ForeignColumn("ObraId")
                .ToTable("Obras").PrimaryColumn("Id")
                .OnDeleteOrUpdate(Rule.SetNull);
        }

        public override void Down()
        {
            Delete.ForeignKey("FK_GenerosObras_ObraId");
            Delete.ForeignKey("FK_ComprasObras_CompraId");
            Delete.ForeignKey("FK_ComprasObras_ObraId");
        }
    }
}
