using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Transform;

/**
 * CreateEcoVehicleTypeCommandFromResourceAssembler class
 */
public static class CreateEcoVehicleTypeCommandFromResourceAssembler
{
    /**
     * ToCommandFromResource method
     * Convert CreateEcoVehicleTypeResource to CreateEcoVehicleTypeCommand
     * <param name="resource">The CreateEcoVehicleTypeResource</param>
     * <returns>The CreateEcoVehicleTypeCommand</returns>
     */
    public static CreateEcoVehicleTypeCommand ToCommandFromResource(this CreateEcoVehicleTypeResource resource)
    {
        return new CreateEcoVehicleTypeCommand(resource.Name);
    }
}