using ecomove_web_service.VehicleManagement.Domain.Model.Entities;
using ecomove_web_service.VehicleManagement.Domain.Model.Queries;

namespace ecomove_web_service.VehicleManagement.Domain.Services;

public interface IEcoVehicleTypeQueryService
{
    Task<EcoVehicleType?> Handle(GetEcoVehicleTypeByEcoVehicleTypeIdQuery query);
}