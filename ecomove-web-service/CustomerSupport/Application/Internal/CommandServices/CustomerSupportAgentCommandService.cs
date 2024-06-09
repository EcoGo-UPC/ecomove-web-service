using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.CustomerSupport.Application.Internal.CommandServices;

public class CustomerSupportAgentCommandService(ICustomerSupportAgentRepository customerSupportAgentRepository, IUnitOfWork unitOfWork)
    : ICustomerSupportAgentCommandService
{
    public async Task<CustomerSupportAgent?> Handle(CreateCustomerSupportAgentCommand command)
    {
        var customerSupportAgent = new CustomerSupportAgent(command.FirstName, command.LastName, command.Email);
        await customerSupportAgentRepository.AddAsync(customerSupportAgent);
        await unitOfWork.CompleteAsync();
        return customerSupportAgent;
    }
}