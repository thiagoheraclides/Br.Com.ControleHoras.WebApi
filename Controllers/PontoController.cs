using Br.Com.ControleHoras.WebApi.DTO;
using Br.Com.ControleHoras.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.ControleHoras.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PontoController(ILogger<PontoController> logger) : ControllerBase
    {
        private readonly ILogger<PontoController> _logger = logger;

        [HttpPost(Name = "CadastrarNovoPeriodo")]
        public IActionResult CadastrarPeriodo([FromBody] PeriodoDTO dto)
        {
            Periodo periodo = new(dto.Inicio, dto.Fim);
            
            return Ok(periodo);
        }
    }
}
