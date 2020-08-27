using Devboost.DependecyInjection.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Domain.Interface.DomainService
{
    public interface IProdutoDomainService
    {
        Task<List<Produto>> Listar();
    }
}
