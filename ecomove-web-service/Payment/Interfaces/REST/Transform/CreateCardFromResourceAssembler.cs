using ecomove_web_service.Payment.Domain.Model.Commands;
using ecomove_web_service.Payment.Interfaces.REST.Resources;

namespace ecomove_web_service.Payment.Interfaces.REST.Transform;

public static class CreateCardFromResourceAssembler
{
    public static CreateCardCommand FromResource(CreateCardResource resource)
    {
        return new CreateCardCommand(resource.UserId, resource.CardNumber, resource.ExpirationDate);
    }
}