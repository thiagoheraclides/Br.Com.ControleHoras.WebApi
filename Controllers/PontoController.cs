using Microsoft.AspNetCore.Mvc;

namespace Br.Com.ControleHoras.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PontoController(ILogger<PontoController> logger) : ControllerBase
    {
        private readonly ILogger<PontoController> _logger = logger;

        [HttpPost(Name = "CadastrarNovoPeriodo")]
        public IActionResult CadastrarPeriodo([FromBody] ushort ano, ushort mes)
        {
            return Ok();
        }
    }
}
