using Microsoft.AspNetCore.Mvc;

namespace ProjetoB3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestimentoController : ControllerBase
    {
        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] InvestimentoModel investimento)
        {
            try
            {
                if (investimento.ValorInicial <= 0 || investimento.PrazoMeses <= 1)
                {
                    return BadRequest("Invalid values.");
                }

                InvestimentoModel resultado = CalculadoraInvestimento.Calcular(investimento.ValorInicial, investimento.PrazoMeses);

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
