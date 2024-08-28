using Microsoft.AspNetCore.Mvc;

namespace TestLite27.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
    }
}