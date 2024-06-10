using System.ComponentModel;
using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;

namespace ecomove_web_service.CustomerSupport.Domain.Model.Entities;

public class TicketCategory
{
    public TicketCategory()
    {
        Name = string.Empty;
    }

    public TicketCategory(string name)
    {
        Name = name;
    }
    
    public int TicketCategoryId { get; set; }
    public string Name { get; set; }
    public ICollection<Ticket> Tickets { get; }
}