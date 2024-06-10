using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Domain.Model.Entities;
using ecomove_web_service.VehicleManagement.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Services;

namespace ecomove_web_service.VehicleManagement.Application.Internal.CommandServices;

public class EcoVehicleTypeCommandService(IEcoVehicleTypeRepository ecoVehicleTypeRepository, IUnitOfWork unitOfWork) : IEcoVehicleTypeCommandService
{
    public async Task<EcoVehicleType?> Handle(CreateEcoVehicleTypeCommand command)
    {
        var ecoVehicleType = new EcoVehicleType(command.Name);
        await ecoVehicleTypeRepository.AddAsync(ecoVehicleType);
        await unitOfWork.CompleteAsync();
        return ecoVehicleType;
    }
}