using ecomove_web_service.UserManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.Payment.Domain.Model.Entities;

public class Card
{
    public Card()
    {
        UserId = 0;
        CardNumber = string.Empty;
        ExpirationDate = string.Empty;
    }

    public Card(int userId, string cardNumber, string expirationDate)
    {
        UserId = userId;
        CardNumber = cardNumber;
        ExpirationDate = expirationDate;
    }

    public int CardId { get; set; }
    
    public User User { get; internal set; }
    public int UserId { get; private set; }
    public string CardNumber { get; private set; }
    public string ExpirationDate { get; private set; }
}