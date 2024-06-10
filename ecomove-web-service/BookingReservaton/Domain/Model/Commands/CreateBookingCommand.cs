namespace ecomove_web_service.BookingReservation.Domain.Model.Commands;

public record CreateBookingCommand(int UserId, int VehicleId, DateTime StartTime, DateTime EndTime, string Status);