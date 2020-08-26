using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.DomainService
{
    public class ClienteDomainService : IClienteDomainService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteDomainService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<List<Cliente>> Listar()
        {
            return _clienteRepository.Listar();
        }
    }
}
