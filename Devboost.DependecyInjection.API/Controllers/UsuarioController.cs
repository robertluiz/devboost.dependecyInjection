using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Devboost.DependecyInjection.API.Controllers
{
    public class UsuarioController : Controller
    {
        // GET
        public async Task<IActionResult> Listar()
        {
            return Ok();
        }
    }
}