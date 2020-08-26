namespace Devboost.DependecyInjection.Domain.Entidades
{
    public class Pedido : EntidadeBase<int>
    {
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }        
    }
}