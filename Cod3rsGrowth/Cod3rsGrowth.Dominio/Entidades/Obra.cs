using Cod3rsGrowth.Dominio.Enums;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Dominio.Entidades
{
    [Table("Obras")]
    public class Obra
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column("Titulo"), NotNull]
        public string Titulo { get; set; }

        [Column("Autor"), NotNull]
        public string Autor { get; set; }

        [Column("NumeroCapitulos"), NotNull]
        public int NumeroCapitulos { get; set; }

        [Column("Valor"), NotNull]
        public decimal ValorObra { get; set; }

        [Column("Formato"), NotNull]
        public Formato Formato { get; set; }

        [Column("Finalizada"), NotNull]
        public bool FoiFinalizada { get; set; }

        [Column("InicioPublicacao"), NotNull]
        public DateTime InicioPublicacao { get; set; }

        [Column("Sinopse"), NotNull]
        public string Sinopse { get; set; }
        public List<Genero> Generos { get; set; }
        public string? CapaImagemBase64 { get; set; }
    }
}
