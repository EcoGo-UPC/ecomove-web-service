namespace ecomove_web_service.BookingReservation.Interfaces.REST.Resources;

public record BookingResource(int Id, int UserId, int VehicleId, DateTime StartTime, DateTime EndTime, string Status);