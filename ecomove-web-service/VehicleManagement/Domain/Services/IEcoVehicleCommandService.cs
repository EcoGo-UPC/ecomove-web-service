using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Domain.Model.Commands;

namespace ecomove_web_service.VehicleManagement.Domain.Services;

public interface IEcoVehicleCommandService
{
    Task<EcoVehicle?> Handle(CreateEcoVehicleCommand command);
}