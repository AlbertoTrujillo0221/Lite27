using Application.Dtos;
using Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace TestLite27.Controllers
{
    public class TransactionController(IServiceTransaction serviceTransaction) : BaseController
    {
        [HttpGet(Name = "Get")]
        public async Task<IEnumerable<TransactionDto>> Get()
        {
            return await serviceTransaction.GetAll();
        }
    }
}
