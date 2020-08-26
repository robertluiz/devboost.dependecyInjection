using System;

namespace Devboost.DependecyInjection.Domain.Entidades
{
    public class Cliente : EntidadeBase<int>
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        
    }
}