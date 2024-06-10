using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Services;

namespace ecomove_web_service.UserManagement.Application.Internal.CommandServices;

public class MembershipCategoryCommandService(IMembershipCategoryRepository membershipCategoryRepository, IUnitOfWork unitOfWork) : IMembershipCategoryCommandService
{
    public async Task<MembershipCategory?> Handle(CreateMembershipCategoryCommand command)
    {
        var membershipCategory = new MembershipCategory(command.Name);
        await membershipCategoryRepository.AddAsync(membershipCategory);
        await unitOfWork.CompleteAsync();
        return membershipCategory;
    }    
}