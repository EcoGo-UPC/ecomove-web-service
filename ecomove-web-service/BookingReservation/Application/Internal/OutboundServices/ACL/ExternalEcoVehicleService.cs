using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Interfaces.ACL;

namespace ecomove_web_service.BookingReservation.Application.Internal.OutboundServices.ACL;

public class ExternalEcoVehicleService(IVehicleManagementContextFacade vehicleManagementContextFacade)
{
    public async Task<EcoVehicle> FetchEcoVehicleById(int id)
    {
        var vehicle = await vehicleManagementContextFacade.FetchVehicleByVehicleId(id);
        if (vehicle == null)
        {
            throw new BadHttpRequestException("There is no vehicle found with id + " + id + ". ");
        }
        return vehicle;
    }
}