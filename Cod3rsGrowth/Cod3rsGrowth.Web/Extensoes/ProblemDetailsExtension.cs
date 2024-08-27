using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Cod3rsGrowth.Web.Extensoes
{
    public static class ProblemDetailsExtension
    {
        public static void UseProblemDetailsExceptionHandler(this IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (exceptionHandlerFeature != null)
                    {
                        var exception = exceptionHandlerFeature.Error;
                        var problemDetails = new ProblemDetails
                        {
                            Instance = context.Request.HttpContext.Request.Path
                        };
                        if (exception is BadHttpRequestException badHttpRequestException)
                        {
                            problemDetails.Title = "A requisição é inválida";
                            problemDetails.Status = StatusCodes.Status400BadRequest;
                            problemDetails.Detail = badHttpRequestException.Message;
                        }
                        else
                        {
                            var logger = loggerFactory.CreateLogger("GlobalExceptionHandler");
                            logger.LogError($"Erro inesperado: {exceptionHandlerFeature.Error}");

                            problemDetails.Title = exception.Message;
                            problemDetails.Status = StatusCodes.Status500InternalServerError;
                            problemDetails.Detail = exception.Demystify().ToString();
                            problemDetails.Extensions["Erros"] = exception.Message.Split("\r\n");
                        }
                        context.Response.StatusCode = problemDetails.Status.Value;
                        context.Response.ContentType = "application/problem+json";
                        var json = JsonConvert.SerializeObject(problemDetails);
                        await context.Response.WriteAsync(json);
                    }
                });
            });
        }

        public static IServiceCollection ConfigureProblemDetailsModelState(this IServiceCollection services)
        {
            return services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Title = "Erro(s) de validação.",
                        Instance = context.HttpContext.Request.Path,
                        Status = StatusCodes.Status400BadRequest,
                        Detail = "Consulte a propriedade de erros para detalhes "
                    };
                    return new BadRequestObjectResult(problemDetails)
                    {
                        ContentTypes = { "application/problem+json", "application/problem+xml" }
                    };
                };
            });
        }
    }
}
