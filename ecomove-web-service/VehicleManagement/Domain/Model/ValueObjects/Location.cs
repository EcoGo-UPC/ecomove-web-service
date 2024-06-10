namespace ecomove_web_service.VehicleManagement.Domain.ValueObjects;

public record Location(double Latitude, double Longitude)
{
    public Location() : this(0, 0)
    {
    }
    
    public Location(double latitude) : this(latitude, 0)
    {
    }
    
    public object GetLocationObject()
    {
        return new 
        {
            Latitude,
            Longitude
        };
    }
}