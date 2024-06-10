using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;
using ecomove_web_service.VehicleManagement.Domain.Model.Queries;

namespace ecomove_web_service.VehicleManagement.Domain.Services;

public interface IEcoVehicleQueryService
{
    Task<EcoVehicle?> Handle(GetEcoVehicleByEcoVehicleIdQuery query);
    Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesQuery query);
    Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByEcoVehicleTypeIdAndModelQuery query);
    Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByBatteryLevelGreaterThanQuery query);
    Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByEcoVehicleTypeIdAndStatusQuery query);
    Task<IEnumerable<EcoVehicle>> Handle(GetAllEcoVehiclesByEcoVehicleTypeIdQuery idQuery);
}