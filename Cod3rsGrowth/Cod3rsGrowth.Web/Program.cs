using Cod3rsGrowth.Web.Extensoes;
using Cod3rsGrowth.Web.ModuloDeInjecao;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var servicos = builder.Services;
var comando = args.FirstOrDefault();
var stringDeConexao = comando is "--teste" ? builder.Configuration.GetConnectionString("StringConexaoTeste") 
                        : builder.Configuration.GetConnectionString("StringConexao");

ModuloDeInjecaoWeb.BindService(servicos, stringDeConexao);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions { ServeUnknownFileTypes = true });

app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "wwwroot/webapp")),
    EnableDirectoryBrowsing = true
});

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/i18n"))
    {
        var filePath = Path.Combine(builder.Environment.ContentRootPath, "wwwroot/webapp/i18n", context.Request.Path.Value.Substring(6));
        if (File.Exists(filePath))
        {
            await context.Response.SendFileAsync(filePath);
            return;
        }
    }

    await next();
});

app.UseProblemDetailsExceptionHandler(app.Services.GetRequiredService<ILoggerFactory>());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();