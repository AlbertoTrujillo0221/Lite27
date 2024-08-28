using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        public async Task<IEnumerable<TransactionEntity>> GetAll()
        {
            var transactions = new List<TransactionEntity>()
            {
                new TransactionEntity()
                {
                    Id = 1,
                    Value = 1,
                },
                new TransactionEntity()
                {
                    Id = 2,
                    Value = 2,
                },
                new TransactionEntity()
                {
                    Id = 3,
                    Value = 3,
                }
            };

            await Task.CompletedTask;

            return transactions;
        }
    }
}
