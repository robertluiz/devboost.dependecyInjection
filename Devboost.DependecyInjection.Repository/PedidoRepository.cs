using Devboost.DependecyInjection.Domain.Entidades;
using Devboost.DependecyInjection.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public Task<List<Pedido>> Listar()
        {
            var listaPedidos = new List<Pedido>()
            {
                new Pedido
                {
                    Id = 1,
                    Cliente = new Cliente
                    {
                        Id = 1,
                        Nome = "Cliente 1",
                        DataNascimento = DateTime.Now
                    },
                    Descricao = "Pedido 1",
                    Produtos =new List<Produto>()
                    {
                        new Produto
                        {
                            Id = 1,
                            Nome = "Produto 1",
                            Valor = 10
                        }
                    }
                }
            };

            return Task.Factory.StartNew(() => listaPedidos);
        }
    }
}
