using ecomove_web_service.VehicleManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.VehicleManagement.Domain.Model.Entities;

public class EcoVehicleType
{
    public EcoVehicleType()
    {
        Name = string.Empty;
    }

    public EcoVehicleType(string name)
    {
        Name = name;
    }
    
    public int EcoVehicleTypeId { get; set; }
    public string Name { get; set; }
    public ICollection<EcoVehicle> EcoVehicles { get; }
}