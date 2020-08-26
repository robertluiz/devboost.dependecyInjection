using Devboost.DependecyInjection.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devboost.DependecyInjection.Domain.Interface.DomainService
{
    public interface IDomainServiceListarProdutos
    {
         List<Produto> Executar();
    }
}
