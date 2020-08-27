using System.Threading.Tasks;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Microsoft.AspNetCore.Mvc;

namespace Devboost.DependecyInjection.API.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IClienteDomainService _clienteService;

        public UsuarioController(IClienteDomainService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET
        public async Task<IActionResult> Listar()
        {
            var clientes = await _clienteService.Listar();
            return Ok(clientes);
        }
    }
}