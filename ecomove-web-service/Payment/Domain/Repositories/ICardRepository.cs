using ecomove_web_service.Payment.Domain.Model.Entities;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.Payment.Domain.Repositories;

public interface ICardRepository: IBaseRepository<Card>
{
    Task <Card?> FindByUserIdAsync(int userId);
}