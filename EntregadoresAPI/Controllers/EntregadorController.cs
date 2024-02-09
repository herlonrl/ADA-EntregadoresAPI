using EntregadoresAPI.Filters;
using EntregadoresAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntregadoresAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregadorController : ControllerBase
    {
        private static List<Entregador> entregadores = new List<Entregador>();

        [HttpGet("{cpf}")]
        public IActionResult GetEntregador(string cpf)
        {
            return Ok(entregadores.FirstOrDefault(x => x.CPF == cpf)); 
        }
        
        [HttpPost]
        [AuthorizationFilter]
        public IActionResult PostEntregador([FromBody] Entregador entregador)
        {
            if (entregador == null)
                return BadRequest();

            entregadores.Add(entregador);

            return Ok(entregador);
        }
    }
}
