using ecomove_web_service.UserManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.UserManagement.Domain.Model.Entities;

public class MembershipCategory
{
    public MembershipCategory()
    {
        Name = string.Empty;
    }

    public MembershipCategory(string name)
    {
        Name = name;
    }
    
    public int MembershipCategoryId { get; set; }
    public string Name { get; set; }
    public ICollection<Membership> Memberships { get; }
}