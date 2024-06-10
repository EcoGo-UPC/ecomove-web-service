using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Domain.Model.Commands;
using ecomove_web_service.VehicleManagement.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Services;

namespace ecomove_web_service.VehicleManagement.Application.Internal.CommandServices;

public class EcoVehicleCommandService(IEcoVehicleRepository ecoVehicleRepository, IUnitOfWork unitOfWork) : IEcoVehicleCommandService 
{
    public async Task<EcoVehicle?> Handle(CreateEcoVehicleCommand command)
    {
        var ecoVehicle = new EcoVehicle(command);
        try
        {
            await ecoVehicleRepository.AddAsync(ecoVehicle);
            await unitOfWork.CompleteAsync();
            return ecoVehicle;
        } 
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the ecoVehicle: {e.Message}");
            throw;
        }
    }
}