namespace ecomove_web_service.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}