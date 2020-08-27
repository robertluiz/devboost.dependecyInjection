using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public Task<List<Cliente>> Listar()
        {
            var listaCliente = new List<Cliente>()
            {
                new Cliente
                {
                    Id = 1,
                    Nome = "Cliente 1",
                    DataNascimento = DateTime.Now
                }
            };

            return Task.Factory.StartNew(() => listaCliente);
        }
    }
}
