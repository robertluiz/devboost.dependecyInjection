using System.Threading.Tasks;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Microsoft.AspNetCore.Mvc;

namespace Devboost.DependecyInjection.API.Controllers
{
    [Route("v1/pedido")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly IPedidoDomainService _pedidoService;

        public PedidoController(IPedidoDomainService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        // GET
        [HttpGet("listar")]
        public async Task<IActionResult> Listar()
        {
            var pedidos = await _pedidoService.Listar();
            return Ok(pedidos);
        }
    }
}