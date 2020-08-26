using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.DomainService
{
    public class PedidoDomainService : IPedidoDomainService
    {
        public Task<List<Pedido>> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}
