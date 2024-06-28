using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.VehicleManagement.Interfaces.ACL;

/**
 * IVehicleManagementContextFacade interface
 */
public interface IVehicleManagementContextFacade
{ 
    Task<EcoVehicle?> FetchVehicleByVehicleId(int vehicleId);
}