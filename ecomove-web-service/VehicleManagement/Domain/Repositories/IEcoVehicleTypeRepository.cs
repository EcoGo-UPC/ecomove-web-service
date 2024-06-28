using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Model.Entities;

namespace ecomove_web_service.VehicleManagement.Domain.Repositories;

/**
 * IEcoVehicleTypeRepository interface
 * 
 */
public interface IEcoVehicleTypeRepository : IBaseRepository<EcoVehicleType>
{
    Task<EcoVehicleType?> FindEcoVehicleTypeByEcoVehicleTypeIdAsync(int ecoVehicleTypeId);
    
    Task<IEnumerable<EcoVehicleType>> FindAllEcoVehicleTypesAsync();
}