using Application.Dtos;
using Domain.Interfaces.Application;
using Infrastructure.Interfaces;

namespace Application.Services
{
    public class ServiceTransaction(IGenericRepository genericRepository) : IServiceTransaction
    {
        public async Task<IEnumerable<TransactionDto>> GetAll()
        {
            var transactions = await genericRepository.GetAll();

            var response = transactions.Select(x =>
            {
                return new TransactionDto
                {
                    Id = x.Id,
                    Value = x.Value,
                };
            });

            return response;
        }
    }
}
