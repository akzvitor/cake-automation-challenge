using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Servico.Servicos;
using Cod3rsGrowth.Servico.Validadores;
using Cod3rsGrowth.Testes.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Testes.ConfiguracaoAmbienteTeste
{
    public static class ModuloDeInjecao
    {
        public static void BindService(ServiceCollection servicos)
        {
            servicos.AddScoped<ServicoObra>();
            servicos.AddScoped<ServicoCompraCliente>();

            servicos.AddScoped<IRepositorioObra, RepositorioObraMock>();
            servicos.AddScoped<IRepositorioCompraCliente, RepositorioCompraClienteMock>();

            servicos.AddScoped<ObraValidador>();
            servicos.AddScoped<CompraClienteValidador>();
        }
    }
}