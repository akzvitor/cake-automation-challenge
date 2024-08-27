using FluentMigrator;

namespace Cod3rsGrowth.Dominio.Migracoes
{
    [Migration(20240617082300)]
    public class AddGenerosObras : Migration
    {
        public override void Up()
        {
            Create.Table("GenerosObras")
                .WithColumn("ObraId").AsInt32().ForeignKey("Obras", "Id")
                .WithColumn("Genero").AsInt32();
        }

        public override void Down()
        {
            Delete.Table("GenerosObras");
        }
    }
}
