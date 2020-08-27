using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task<List<Produto>> Listar()
        {
            var listaProduto = new List<Produto>()
            {
                new Produto
                {
                    Id = 1,
                    Nome = "Produto 1",
                    Valor = 10
                }
            };

            return Task.Factory.StartNew(() => listaProduto);
        }
    }
}
