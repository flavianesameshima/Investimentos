using Microsoft.AspNetCore.Mvc;

namespace Investimentos.API.Controllers
{
    public class BancoController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
