using Cod3rsGrowth.Infra.ConexaoDeDados;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Infra.InjecaoDeDependencia
{
    public static class ModuloDeInjecao
    {
        public static void BindService(ServiceCollection conexao)
        {
            conexao.AddScoped<DbCodersGrowth>();
        }
    }
}
