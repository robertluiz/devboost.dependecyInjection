using System;
using System.Collections.Generic;
using System.Text;

namespace Devboost.DependecyInjection.Domain.Entidades
{
    public class Produto : EntidadeBase
    {

        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public int  valor { get; set; }
    }
}
