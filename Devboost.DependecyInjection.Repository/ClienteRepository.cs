﻿using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public Task<List<Cliente>> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}
