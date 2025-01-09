using Microsoft.AspNetCore.Diagnostics;
using TaskManagementSystem_BL.Exceptions;

namespace TaskManagementSystem_API;

public static class ServiceRegistration
{
    public static IApplicationBuilder ExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(x =>
        {
            x.Run(async context =>
            {
                var feature = context.Features.Get<IExceptionHandlerFeature>();
                var exception = feature!.Error;
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                if (exception is IBaseException ibe)
                {
                    context.Response.StatusCode = ibe.StatusCode;
                    await context.Response.WriteAsJsonAsync(new
                    {
                        StatusCode = ibe.StatusCode,
                        Message = ibe.ErrorMessage
                    });
                }
                else
                {
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    await context.Response.WriteAsJsonAsync(new
                    {
                        StatusCode = StatusCodes.Status400BadRequest,
                        Message = exception.Message
                    });
                }

            });

        });
        return app;
    }
}
