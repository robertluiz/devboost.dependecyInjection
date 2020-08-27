using System.Threading.Tasks;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Devboost.DependecyInjection.API.Controllers
{
    [Route("v1/produto")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoDomainService _produtoService;

        public ProdutoController(IProdutoDomainService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET
        [HttpGet("listar")]
        public async Task<IActionResult> Listar()
        {
            var produtos = await _produtoService.Listar();
            return Ok(produtos);
        }
    }
}