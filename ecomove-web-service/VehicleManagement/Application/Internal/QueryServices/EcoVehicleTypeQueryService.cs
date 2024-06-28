using ecomove_web_service.VehicleManagement.Domain.Model.Entities;
using ecomove_web_service.VehicleManagement.Domain.Model.Queries;
using ecomove_web_service.VehicleManagement.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Services;

namespace ecomove_web_service.VehicleManagement.Application.Internal.QueryServices;

public class EcoVehicleTypeQueryService(IEcoVehicleTypeRepository ecoVehicleTypeRepository) : IEcoVehicleTypeQueryService
{
    public async Task<EcoVehicleType?> Handle(GetEcoVehicleTypeByEcoVehicleTypeIdQuery query)
    {
        return await ecoVehicleTypeRepository.FindByIdAsync(query.EcoVehicleTypeId);
    }
    
    public async Task<IEnumerable<EcoVehicleType>> Handle(GetAllEcoVehicleTypesQuery query)
    {
        return await ecoVehicleTypeRepository.FindAllEcoVehicleTypesAsync();
    }
}