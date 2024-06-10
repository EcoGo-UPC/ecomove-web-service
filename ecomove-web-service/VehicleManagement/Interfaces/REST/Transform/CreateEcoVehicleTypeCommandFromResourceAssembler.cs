using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Transform;

public static class CreateEcoVehicleTypeCommandFromResourceAssembler
{
    public static CreateEcoVehicleTypeCommand ToCommandFromResource(this CreateEcoVehicleTypeResource resource)
    {
        return new CreateEcoVehicleTypeCommand(resource.Name);
    }
}