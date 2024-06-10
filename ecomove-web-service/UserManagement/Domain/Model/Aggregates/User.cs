using System.Text.Json.Serialization;
using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.Payment.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Domain.Model.ValueObjects;

namespace ecomove_web_service.UserManagement.Domain.Model.Aggregates;

public partial class User
{
    public User()
    {
        Name = new PersonName();
        Username = string.Empty;
        Email = new EmailAddress();
        PasswordHash = string.Empty;
    }
    
    public User(string firstName, string lastName, string email, string username, string passwordHash)
    {
        Name = new PersonName(firstName, lastName);
        Username = username;
        Email = new EmailAddress(email);
        PasswordHash = passwordHash;
    }
    
    
    
    public int UserId { get; }
    public PersonName Name { get; private set; }
    public string Username { get; private set; }
    public EmailAddress Email { get; private set; }
    [JsonIgnore] public string PasswordHash { get; private set; }
    
    public string FullName => Name.FullName;
    
    public string EmailAddress => Email.Address;
    
    public ICollection<Membership> Memberships { get; }
    
    public ICollection<Booking> Bookings { get; }
    
    public ICollection<Ticket> Tickets { get; }
    
    public ICollection<Card> Cards { get; }
    
}