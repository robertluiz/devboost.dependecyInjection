using Devboost.DependecyInjection.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Domain.Interface.Repository
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> Listar();
    }
}
