using System.Net.Mime;
using ecomove_web_service.UserManagement.Domain.Model.Queries;
using ecomove_web_service.UserManagement.Domain.Services;
using ecomove_web_service.UserManagement.Infrastructure.Pipeline.Middleware.Attributes;
using ecomove_web_service.UserManagement.Interfaces.REST.Resources;
using ecomove_web_service.UserManagement.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ecomove_web_service.UserManagement.Interfaces.REST;

/**
 * <summary>
 *     The users controller.
 * </summary>
 * <remarks>
 *    This class is responsible for handling the user-related requests.
 * </remarks>
 */

[Authorize]
[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class UsersController(IUserQueryService userQueryService) : ControllerBase
{
    /**
     * <summary>
     *    Get user by username endpoint. It allows to get a user by username.
     * </summary>
     * <param name="username">The username of the user.</param>
     * <returns>The user resource.</returns>
     */
    [HttpGet("{username}")]
    [SwaggerOperation(
        Summary = "Gets a user by username",
        Description = "Gets a user for a given username",
        OperationId = "GetUserByUsername")]
    [SwaggerResponse(200, "The user was found", typeof(UserResource))]
    public async Task<IActionResult> GetUserByUsername(string username)
    {
        var getUserByUsernameQuery = new GetUserByUsernameQuery(username);
        var user = await userQueryService.Handle(getUserByUsernameQuery);
        var userResource = UserResourceFromEntityAssembler.ToResourceFromEntity(user!);
        return Ok(userResource);
    }
}