using Application.Dtos;

namespace Domain.Interfaces.Application
{
    public interface IServiceTransaction
    {
        Task<IEnumerable<TransactionDto>> GetAll();
    }
}
