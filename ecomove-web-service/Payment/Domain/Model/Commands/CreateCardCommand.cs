namespace ecomove_web_service.Payment.Domain.Model.Commands;

public record CreateCardCommand(int UserId, string CardNumber, string ExpirationDate);