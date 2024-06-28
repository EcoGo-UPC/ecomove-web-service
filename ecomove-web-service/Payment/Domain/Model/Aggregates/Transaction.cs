using ecomove_web_service.Payment.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.Payment.Domain.Model.Aggregates;

/**
 * Represents a transaction.
 * <summary>
 *   A transaction is a record of an amount of money being transferred from one use.
 * </summary>
 * 
 */
public class Transaction
{
    public Transaction()
    {
        UserId = 0;
        Amount = 0;
        Date = DateTime.Now;
    }
    
    public Transaction(int userId, double amount, DateTime date)
    {
        UserId = userId;
        Amount = amount;
        Date = date;
    }
    
    public Transaction(CreateTransactionCommand command)
    {
        UserId = command.UserId;
        Amount = command.Amount;
        Date = command.Date;
    }
    
    public int TransactionId { get; private set; }
    
    public User User { get; internal set; }
    public int UserId { get; private set; }
    
    public double Amount { get; private set; }
    
    public DateTime Date { get; private set; }
    
}