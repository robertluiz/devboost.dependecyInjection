using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.DomainService
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task<List<Produto>> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}
