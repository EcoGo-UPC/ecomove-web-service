using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Services;

namespace ecomove_web_service.UserManagement.Application.Internal.CommandServices;

/**
 * Service for handling commands related to membership categories.
 * <summary>
 *  This service is used to handle the commands related to membership categories.
 * </summary>
 * <remarks>
 * This class implements the IMembershipCategoryCommandService interface.
 * </remarks>
 */
public class MembershipCategoryCommandService(IMembershipCategoryRepository membershipCategoryRepository, IUnitOfWork unitOfWork) : IMembershipCategoryCommandService
{
    /**
     * Handle the command to create a new membership category.
     * <param name="command">The command to create a new membership category.</param>
     * <returns>The newly created membership category.</returns>
     */
    public async Task<MembershipCategory?> Handle(CreateMembershipCategoryCommand command)
    {
        var membershipCategory = new MembershipCategory(command.Name);
        await membershipCategoryRepository.AddAsync(membershipCategory);
        await unitOfWork.CompleteAsync();
        return membershipCategory;
    }    
}