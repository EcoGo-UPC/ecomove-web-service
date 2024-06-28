namespace ecomove_web_service.VehicleManagement.Domain.Model.Queries;

/**
 * GetAllEcoVehiclesByEcoVehicleTypeIdAndModelQuery record
 */
public record GetAllEcoVehiclesByEcoVehicleTypeIdAndModelQuery(int EcoVehicleTypeId, string Model);