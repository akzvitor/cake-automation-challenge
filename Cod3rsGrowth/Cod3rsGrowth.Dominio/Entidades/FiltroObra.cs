using Cod3rsGrowth.Dominio.Enums;
using Cod3rsGrowth.Dominio.Interfaces;

namespace Cod3rsGrowth.Dominio.Entidades
{
    public class FiltroObra : IFiltro
    {
        public string? Autor { get; set; }
        public string? Titulo { get; set; }
        public List<Genero>? Generos { get; set; }
        public Formato? Formato { get; set; }
        public bool? Finalizada { get; set; }
        public string? AnoInicialLancamento { get; set; }
        public string? AnoFinalLancamento { get; set; }
    }
}
