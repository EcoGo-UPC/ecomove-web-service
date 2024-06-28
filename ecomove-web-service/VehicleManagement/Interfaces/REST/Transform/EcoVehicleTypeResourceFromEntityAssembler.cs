using ecomove_web_service.VehicleManagement.Domain.Model.Entities;
using ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Transform;

/**
 * EcoVehicleTypeResourceFromEntityAssembler class
 */
public static class EcoVehicleTypeResourceFromEntityAssembler
{
    /**
     * ToResourceFromEntity method
     * Convert EcoVehicleType to EcoVehicleTypeResource
     * <param name="entity">The EcoVehicleType</param>
     * <returns>The EcoVehicleTypeResource</returns>
     */
    public static EcoVehicleTypeResource ToResourceFromEntity(EcoVehicleType entity)
    {
        return new EcoVehicleTypeResource(entity.EcoVehicleTypeId, entity.Name);
    }
}