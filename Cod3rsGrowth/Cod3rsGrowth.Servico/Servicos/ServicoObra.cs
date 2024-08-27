using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Enums;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Servico.Validadores;
using FluentValidation;

namespace Cod3rsGrowth.Servico.Servicos
{
    public class ServicoObra
    {
        private readonly IRepositorioObra _repositorioObra;
        private readonly ObraValidador _validadorObra;

        public ServicoObra(IRepositorioObra repositorioObra, ObraValidador validadorObra)
        {
            _repositorioObra = repositorioObra;
            _validadorObra = validadorObra;
        }

        public List<Obra> ObterTodos(FiltroObra? filtro = null)
        {
            return _repositorioObra.ObterTodos(filtro);
        }

        public Obra ObterPorId(int id)
        {
            return _repositorioObra.ObterPorId(id);
        }

        public Obra Criar(Obra obra)
        {
            var resultadoValidacao = _validadorObra.Validate(obra);

            if (!resultadoValidacao.IsValid)
            {
                var erros = string.Join(Environment.NewLine, resultadoValidacao.Errors.Select(x => x.ErrorMessage).ToArray());

                throw new ValidationException(erros);
            }
           
            return _repositorioObra.Criar(obra);
        }

        public Obra Editar(Obra obra)
        {
            var resultadoValidacao = _validadorObra.Validate(obra, options =>
            {
                options.IncludeRuleSets("Editar").IncludeRulesNotInRuleSet();
            });

            if (!resultadoValidacao.IsValid)
            {
                var erros = string.Join(Environment.NewLine, resultadoValidacao.Errors.Select(x => x.ErrorMessage).ToArray());

                throw new ValidationException(erros);
            }

            return _repositorioObra.Editar(obra);
        }

        public void Remover(int id)
        {
            _repositorioObra.Remover(id);
        }

        public List<Genero> ObterGenerosVinculados(int obraId)
        {
            return _repositorioObra.ObterGenerosVinculados(obraId);
        }
    }
}
