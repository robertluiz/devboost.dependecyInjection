using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.DomainService
{
    public class ProdutoDomainService : IProdutoDomainService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoDomainService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public Task<List<Produto>> Listar()
        {
            return _produtoRepository.Listar();
        }
    }
}
