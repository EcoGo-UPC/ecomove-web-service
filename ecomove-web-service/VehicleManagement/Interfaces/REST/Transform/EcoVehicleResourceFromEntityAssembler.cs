using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Transform;

public static class EcoVehicleResourceFromEntityAssembler
{
    public static EcoVehicleResource ToResourceFromEntity(EcoVehicle entity)
    {
        return new EcoVehicleResource(entity.EcoVehicleId, entity.Model, entity.EcoVehicleTypeId, entity.BatteryLevel,
            entity.Location, entity.Status, entity.ImageUrl);
    }
}