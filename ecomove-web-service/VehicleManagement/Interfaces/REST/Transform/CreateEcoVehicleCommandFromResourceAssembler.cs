using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Transform;

public static class CreateEcoVehicleCommandFromResourceAssembler
{
    public static CreateEcoVehicleCommand ToCommandFromResource(CreateEcoVehicleResource resource)
    {
        return new CreateEcoVehicleCommand(resource.Model, resource.EcoVehicleTypeId, resource.BatteryLevel, resource.Latitude,
            resource.Longitude, resource.Status, resource.ImageUrl);
    }
}