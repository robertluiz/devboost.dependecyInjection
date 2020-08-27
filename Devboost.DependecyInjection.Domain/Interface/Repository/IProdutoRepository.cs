using Devboost.DependecyInjection.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Domain.Interface.Repository
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> Listar();
    }
}
