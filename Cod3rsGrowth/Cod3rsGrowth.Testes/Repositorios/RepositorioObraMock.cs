using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Enums;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Infra.Repositorios;

namespace Cod3rsGrowth.Testes.Repositorios
{
    public class RepositorioObraMock : IRepositorioObra
    {
        private List<Obra> _listaObra = ListaSingleton.Instancia.ListaObra;
        private int _obraId = 100;

        public List<Obra> ObterTodos(FiltroObra? filtro = null)
        {
            return _listaObra;
        }

        public Obra ObterPorId(int id)
        {
            var obraRequisitada = _listaObra.Find(obra => obra.Id == id)
                ?? throw new Exception($"O ID informado ({id}) é inválido. Obra não encontrada.");
            return obraRequisitada;
        }

        public Obra Criar(Obra obra)
        { 
            obra.Id = _obraId;
            _obraId++;
            _listaObra.Add(obra);

            return obra;
        }

        public Obra Editar(Obra obra)
        {
            var obraNoBanco = ObterPorId(obra.Id);

            obraNoBanco.Titulo = obra.Titulo;
            obraNoBanco.Autor = obra.Autor;
            obraNoBanco.NumeroCapitulos = obra.NumeroCapitulos;
            obraNoBanco.InicioPublicacao = obra.InicioPublicacao;
            obraNoBanco.ValorObra = obra.ValorObra;
            obraNoBanco.FoiFinalizada = obra.FoiFinalizada;
            obraNoBanco.Sinopse = obra.Sinopse;
            obraNoBanco.Formato = obra.Formato;
            obraNoBanco.Generos = obra.Generos;

            return obraNoBanco;
        }

        public void Remover(int id)
        {
            var obra = ObterPorId(id);

            _listaObra.Remove(obra);
        }

        public List<Genero> ObterGenerosVinculados(int obraId)
        {
            throw new NotImplementedException();
        }
    }
}
