using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.DomainService
{
    public class ClienteDomainService : IClienteDomainService
    {
        public Task<List<Cliente>> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}
