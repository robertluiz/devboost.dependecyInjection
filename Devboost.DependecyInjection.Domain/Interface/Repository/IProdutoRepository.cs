using Devboost.DependecyInjection.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Devboost.DependecyInjection.Domain.Interface.Repository
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> Listar();
    }
}
