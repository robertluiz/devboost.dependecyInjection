using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoRepository(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task<List<Produto>> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}
