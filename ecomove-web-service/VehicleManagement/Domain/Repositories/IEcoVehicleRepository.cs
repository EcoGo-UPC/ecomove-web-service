using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.VehicleManagement.Domain.Repositories;

public interface IEcoVehicleRepository : IBaseRepository<EcoVehicle>
{
    Task<EcoVehicle?> FindEcoVehicleByEcoVehicleIdAsync(int ecoVehicleId);
    
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesAsync();
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByEcoVehicleTypeIdAndModelAsync(int EcoVehicleTypeId, string model);
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByEcoVehicleTypeIdAsync(int EcoVehicleTypeId);
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByEcoVehicleTypeIdAndStatusAsync(int EcoVehicleTypeId, string status);
    Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByBatteryLevelGreaterThanAsync(int batteryLevel);
}