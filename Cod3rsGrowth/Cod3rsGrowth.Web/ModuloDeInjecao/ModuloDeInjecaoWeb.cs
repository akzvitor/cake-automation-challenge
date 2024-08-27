using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Infra.ConexaoDeDados;
using Cod3rsGrowth.Infra.Repositorios;
using Cod3rsGrowth.Servico.Servicos;
using Cod3rsGrowth.Servico.Validadores;
using Cod3rsGrowth.Web.Extensoes;

namespace Cod3rsGrowth.Web.ModuloDeInjecao
{
    public static class ModuloDeInjecaoWeb
    {
        public static void BindService(IServiceCollection servicos, string  stringDeConexao)
        {
            servicos.AddScoped<ServicoObra>();
            servicos.AddScoped<ServicoCompraCliente>();

            servicos.AddScoped<IRepositorioObra, RepositorioObra>();
            servicos.AddScoped<IRepositorioCompraCliente, RepositorioCompraCliente>();

            servicos.AddScoped<ObraValidador>();
            servicos.AddScoped<CompraClienteValidador>();

            servicos.AddScoped(provider => new DbCodersGrowth(stringDeConexao));

            servicos.AddControllers();
            servicos.AddEndpointsApiExplorer();
            servicos.AddSwaggerGen();

            servicos.AddMvc();
            servicos.ConfigureProblemDetailsModelState();
        }
    }
}
