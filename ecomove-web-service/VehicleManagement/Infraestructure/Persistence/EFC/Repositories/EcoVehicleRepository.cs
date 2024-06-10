using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ecomove_web_service.VehicleManagement.Infrastructure.Persistence.EFC.Repositories;

public class EcoVehicleRepository(AppDbContext context) : BaseRepository<EcoVehicle>(context), IEcoVehicleRepository
{
    public Task<EcoVehicle?> FindEcoVehicleByEcoVehicleIdAsync(int ecoVehicleId)
    {
        return Context.Set<EcoVehicle>().FirstOrDefaultAsync(ecoVehicle => ecoVehicle.EcoVehicleId == ecoVehicleId);
    }
    
    public async Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesAsync()
    {
        return await Context.Set<EcoVehicle>().ToListAsync();
    }
    
    public async Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByEcoVehicleTypeIdAndModelAsync(int ecoVehicleTypeId, string model)
    {
        if (ecoVehicleTypeId < 0 || string.IsNullOrEmpty(model))
        {
            throw new ArgumentException("Type and model must be provided.");
        }

        var result = await Context.Set<EcoVehicle>()
            .Where(ecoVehicle => ecoVehicle.EcoVehicleId == ecoVehicleTypeId && ecoVehicle.Model == model)
            .ToListAsync();

        return result.AsEnumerable();
    }
    
    public async Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByBatteryLevelGreaterThanAsync(int batteryLevel)
    {
        if (batteryLevel < 0)
        {
            throw new ArgumentException("Battery level must be greater than 0.");
        }

        var result = await Context.Set<EcoVehicle>()
            .Where(ecoVehicle => ecoVehicle.BatteryLevel > batteryLevel)
            .ToListAsync();

        return result.AsEnumerable();
    }
    
    public async Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByEcoVehicleTypeIdAndStatusAsync(int ecoVehicleTypeId, string status)
    {
        if (ecoVehicleTypeId < 0 || string.IsNullOrEmpty(status))
        {
            throw new ArgumentException("Type and status must be provided.");
        }

        var result = await Context.Set<EcoVehicle>()
            .Where(ecoVehicle => ecoVehicle.EcoVehicleId == ecoVehicleTypeId && ecoVehicle.Status == status)
            .ToListAsync();

        return result.AsEnumerable();
    }
    
    public async Task<IEnumerable<EcoVehicle>> FindAllEcoVehiclesByEcoVehicleTypeIdAsync(int ecoVehicleTypeId)
    {
        if (ecoVehicleTypeId < 0)
        {
            throw new ArgumentException("Type must be provided.");
        }

        var result = await Context.Set<EcoVehicle>()
            .Where(ecoVehicle => ecoVehicle.EcoVehicleId == ecoVehicleTypeId)
            .ToListAsync();

        return result.AsEnumerable();
    }
    
}