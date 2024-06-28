using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Transform;

/**
 * CreateEcoVehicleCommandFromResourceAssembler class
 */
public static class CreateEcoVehicleCommandFromResourceAssembler
{
    /**
     * ToCommandFromResource method
     * Convert CreateEcoVehicleResource to CreateEcoVehicleCommand
     * <param name="resource">The CreateEcoVehicleResource</param>
     * <returns>The CreateEcoVehicleCommand</returns>
     */
    public static CreateEcoVehicleCommand ToCommandFromResource(CreateEcoVehicleResource resource)
    {
        return new CreateEcoVehicleCommand(resource.Model, resource.EcoVehicleTypeId, resource.BatteryLevel, resource.Latitude,
            resource.Longitude, resource.Status, resource.ImageUrl);
    }
}