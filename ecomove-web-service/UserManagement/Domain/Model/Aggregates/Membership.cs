using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Model.Entities;

namespace ecomove_web_service.UserManagement.Domain.Model.Aggregates;

/**
 * Membership aggregate
 */
public partial class Membership
{
    public Membership()
    {
        EndDate = DateTime.Now.AddMonths(1);
    }
    
    public Membership(int userId, int membershipCategoryId)
    {
        UserId = userId;
        MembershipCategoryId = membershipCategoryId;
        EndDate = DateTime.Now.AddMonths(1);
    }

    public Membership(CreateMembershipCommand command)
    {
        UserId = command.UserId;
        MembershipCategoryId = command.MembershipCategoryId;
        EndDate = DateTime.Now.AddMonths(1);
    }
    
    public int MembershipId { get; private set; }
    public User User { get; internal set; }
    public int UserId { get; private set; }
    public MembershipCategory MembershipCategory { get; internal set; }
    public int MembershipCategoryId { get; private set; }
    public DateTimeOffset EndDate { get; private set; }
    
}