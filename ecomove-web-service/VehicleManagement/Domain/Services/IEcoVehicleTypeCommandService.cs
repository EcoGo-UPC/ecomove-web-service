using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Domain.Model.Entities;

namespace ecomove_web_service.VehicleManagement.Domain.Services;

public interface IEcoVehicleTypeCommandService
{
    public Task<EcoVehicleType?> Handle(CreateEcoVehicleTypeCommand command);
}