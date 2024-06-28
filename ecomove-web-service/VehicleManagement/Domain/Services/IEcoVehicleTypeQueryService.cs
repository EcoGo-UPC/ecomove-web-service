using ecomove_web_service.VehicleManagement.Domain.Model.Entities;
using ecomove_web_service.VehicleManagement.Domain.Model.Queries;

namespace ecomove_web_service.VehicleManagement.Domain.Services;

/**
 * IEcoVehicleTypeQueryService interface
 */
public interface IEcoVehicleTypeQueryService
{
    Task<EcoVehicleType?> Handle(GetEcoVehicleTypeByEcoVehicleTypeIdQuery query);
    
    Task<IEnumerable<EcoVehicleType>> Handle(GetAllEcoVehicleTypesQuery query);
}