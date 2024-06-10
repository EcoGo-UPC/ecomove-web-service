using ecomove_web_service.UserManagement.Application.Internal.OutboundServices;
using ecomove_web_service.UserManagement.Domain.Model.Queries;
using ecomove_web_service.UserManagement.Domain.Services;
using ecomove_web_service.UserManagement.Infrastructure.Pipeline.Middleware.Attributes;

namespace ecomove_web_service.UserManagement.Infrastructure.Pipeline.Middleware.Components;

public class RequestAuthorizationMiddleware
{
    private readonly RequestDelegate _next;

    public RequestAuthorizationMiddleware(RequestDelegate next)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
    }

    public async Task InvokeAsync(
        HttpContext context,
        IUserQueryService userQueryService,
        ITokenService tokenService)
    {
        Console.WriteLine("Entering InvokeAsync");

        // Verificar si el endpoint no es nulo antes de acceder a su metadata
        var endpoint = context.GetEndpoint();
        if (endpoint == null)
        {
            Console.WriteLine("Endpoint is null, continuing with next middleware");
            await _next(context);
            return;
        }

        var allowAnonymous = endpoint.Metadata
            .Any(m => m.GetType() == typeof(AllowAnonymousAttribute));
        Console.WriteLine($"Allow Anonymous is {allowAnonymous}");

        if (allowAnonymous)
        {
            Console.WriteLine("Skipping authorization");
            await _next(context);
            return;
        }

        Console.WriteLine("Entering authorization");

        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        if (string.IsNullOrEmpty(token))
        {
            Console.WriteLine("Null or invalid token");
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Unauthorized");
            return;
        }

        try
        {
            var userId = await tokenService.ValidateToken(token);

            if (userId == null)
            {
                Console.WriteLine("Invalid token");
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized");
                return;
            }

            var getUserByIdQuery = new GetUserByUserIdQuery(userId.Value);
            var user = await userQueryService.Handle(getUserByIdQuery);

            if (user == null)
            {
                Console.WriteLine("User not found");
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsync("User not found");
                return;
            }

            Console.WriteLine("Successful authorization. Updating Context...");
            context.Items["User"] = user;
            Console.WriteLine("Continuing with Middleware pipeline...");
            await _next(context);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception during authorization: {ex.Message}");
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await context.Response.WriteAsync("Internal Server Error");
        }
    }
}