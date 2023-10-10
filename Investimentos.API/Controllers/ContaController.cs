using Investimentos.Domain.Entities;
using Investimentos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace Investimentos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        private IContaService _service;

        public ContaController(IContaService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CadastrarConta(Conta conta)
        {
            try
            {
                _service.SalvarConta(conta);
                return Ok(conta);
            }
            catch (Exception)
            {
                return BadRequest();
            }           
        }
    }
}
