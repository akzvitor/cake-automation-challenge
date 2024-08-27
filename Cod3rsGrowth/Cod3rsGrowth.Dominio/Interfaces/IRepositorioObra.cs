using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Enums;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IRepositorioObra : IRepositorio<Obra, FiltroObra>
    {
        List<Genero> ObterGenerosVinculados(int obraId);
    }
}
