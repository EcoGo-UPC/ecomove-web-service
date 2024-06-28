using ecomove_web_service.Payment.Domain.Model.Commands;
using ecomove_web_service.Payment.Interfaces.REST.Resources;

namespace ecomove_web_service.Payment.Interfaces.REST.Transform;

/*
 * Assembler class to convert a CreateTransactionResource object to a CreateTransactionCommand object.
 */
public static class CreateTransactionCommandFromResourceAssembler
{
    /**
    * <param name="resource">The resource object to convert.</param>
    * <returns>The converted command object.</returns>
    */
    public static CreateTransactionCommand ToCommandFromResource(CreateTransactionResource resource)
    {
        return new CreateTransactionCommand(resource.UserId, resource.Amount, resource.Date);
    }
}