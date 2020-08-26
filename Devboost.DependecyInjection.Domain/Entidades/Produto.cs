using System;
using System.Collections.Generic;
using System.Text;

namespace Devboost.DependecyInjection.Domain.Entidades
{
    public class Produto : EntidadeBase<int>
    {

        public string Nome { get; set; }

        public decimal  Valor { get; set; }
    }
}
