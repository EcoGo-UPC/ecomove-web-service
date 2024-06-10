using ecomove_web_service.VehicleManagement.Domain.ValueObjects;

namespace ecomove_web_service.VehicleManagement.Interfaces.REST.Resources;

public record EcoVehicleResource(int Id, string Model, int EcoVehicleTypeId, int BatteryLevel, Location Location, string Status, string ImageUrl);