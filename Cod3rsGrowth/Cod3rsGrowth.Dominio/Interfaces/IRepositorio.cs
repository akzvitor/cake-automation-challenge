namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IRepositorio<T, TFiltro> where TFiltro : IFiltro
    {
        List<T> ObterTodos(TFiltro? filtro);
        T ObterPorId(int id);
        T Criar(T entidade);
        T Editar(T entidade);
        void Remover(int id);
    }
}
