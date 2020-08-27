using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.DomainService
{
    public class PedidoDomainService : IPedidoDomainService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoDomainService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public Task<List<Pedido>> Listar()
        {
            return _pedidoRepository.Listar();
        }
    }
}
