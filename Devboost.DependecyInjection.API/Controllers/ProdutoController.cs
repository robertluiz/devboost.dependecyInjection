using System.Threading.Tasks;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Microsoft.AspNetCore.Mvc;

namespace Devboost.DependecyInjection.API.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoDomainService _produtoService;

        public ProdutoController(IProdutoDomainService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET
        public async Task<IActionResult> Listar()
        {
            var produtos = await _produtoService.Listar();
            return Ok(produtos);
        }
    }
}