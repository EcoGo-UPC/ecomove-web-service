namespace ecomove_web_service.BookingReservation.Interfaces.REST.Resources;

public record CreateBookingResource(int UserId, int VehicleId, DateTime StartTime, DateTime EndTime, string Status);