using ecomove_web_service.VehicleManagement.Domain.Model.Entities;
using ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Transform;

public static class EcoVehicleTypeResourceFromEntityAssembler
{
    public static EcoVehicleTypeResource ToResourceFromEntity(EcoVehicleType entity)
    {
        return new EcoVehicleTypeResource(entity.EcoVehicleTypeId, entity.Name);
    }
}