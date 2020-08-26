using Devboost.DependecyInjection.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Domain.Interface.DomainService
{
    public interface IPedidoDomainService
    {
        Task<List<Pedido>> Listar();
    }
}
