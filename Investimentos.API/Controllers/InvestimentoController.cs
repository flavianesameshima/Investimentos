using Microsoft.AspNetCore.Mvc;

namespace Investimentos.API.Controllers
{
    public class InvestimentoController : ControllerBase
    {
        [HttpPost]
        public IActionResult AdicionarInvestimento()
        {
            return Ok();
        }
    }
}
