using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Domain.Model.Queries;
using ecomove_web_service.VehicleManagement.Domain.Services;

namespace ecomove_web_service.VehicleManagement.Interfaces.ACL.Services;

/**
 * VehicleManagementContextFacade class
 */
public class VehicleManagementContextFacade(IEcoVehicleQueryService vehicleQueryService, IEcoVehicleCommandService vehicleCommandService) : IVehicleManagementContextFacade
{
    /**
     * FetchVehicleByVehicleId method
     * Fetches a vehicle by vehicle id
     * <param name="vehicleId">Vehicle id</param>
     * <returns>EcoVehicle</returns>
     */
    public async Task<EcoVehicle?> FetchVehicleByVehicleId(int vehicleId)
    {
        var query = new GetEcoVehicleByEcoVehicleIdQuery(vehicleId);
        var vehicle = await vehicleQueryService.Handle(query);
        if (vehicle == null)
        {
            return await Task<EcoVehicle?>.FromResult<EcoVehicle?>(null);
        }
        return vehicle;
    }
}