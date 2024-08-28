using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IGenericRepository
    {
        public Task<IEnumerable<TransactionEntity>> GetAll();
    }
}
