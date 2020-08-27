namespace Devboost.DependecyInjection.Domain.Entidades
{
    public class Produto : EntidadeBase<int>
    {

        public string Nome { get; set; }

        public decimal Valor { get; set; }
    }
}
