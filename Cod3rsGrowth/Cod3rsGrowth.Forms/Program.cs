using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Migracoes;
using Cod3rsGrowth.Infra.ConexaoDeDados;
using Cod3rsGrowth.Infra.Repositorios;
using Cod3rsGrowth.Servico.Servicos;
using Cod3rsGrowth.Servico.Validadores;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace Cod3rsGrowth.Forms
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            using (var serviceProvider = CriarServicosDeMigracao())
            using (var escopo = serviceProvider.CreateScope())
            {
                AtualizarBancoDeDados(escopo.ServiceProvider);
            }

            var host = CriarHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<FormListagem>());
        }

        public static IServiceProvider ServiceProvider { get; set; }

        private static ServiceProvider CriarServicosDeMigracao()
        {
            var stringDeConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();

            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(stringDeConexao)
                    .ScanIn(typeof(AddObras).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }

        static IHostBuilder CriarHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((contexto, servicos) => {
                    var stringDeConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();

                    servicos.AddTransient<FormListagem>();

                    servicos.AddScoped<ServicoObra>();
                    servicos.AddScoped<ServicoCompraCliente>();

                    servicos.AddScoped<IRepositorioObra, RepositorioObra>();
                    servicos.AddScoped<IRepositorioCompraCliente, RepositorioCompraCliente>();

                    servicos.AddScoped<ObraValidador>();
                    servicos.AddScoped<CompraClienteValidador>();

                    servicos.AddScoped(provider => new DbCodersGrowth(stringDeConexao));
                });
        }
    }
}