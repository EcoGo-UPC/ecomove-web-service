using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Services;

namespace ecomove_web_service.UserManagement.Application.Internal.CommandServices;

public class MembershipCommandService(IMembershipRepository membershipRepository, IUserRepository userRepository, IMembershipCategoryRepository membershipCategoryRepository, IUnitOfWork unitOfWork) : IMembershipCommandService
{
    public async Task<Membership?> Handle(CreateMembershipCommand command)
    {
        var membership = new Membership(command.UserId, command.MembershipCategoryId);
        await membershipRepository.AddAsync(membership);
        await unitOfWork.CompleteAsync();
        var user = await userRepository.FindByIdAsync(command.UserId);
        membership.User = user;
        var membershipCategory = await membershipCategoryRepository.FindByIdAsync(command.MembershipCategoryId);
        membership.MembershipCategory = membershipCategory;
        return membership;
    }
}
