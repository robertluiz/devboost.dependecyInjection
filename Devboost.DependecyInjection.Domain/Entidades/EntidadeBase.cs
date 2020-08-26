using System;

namespace Devboost.DependecyInjection.Domain.Entidades
{
    public abstract class EntidadeBase<TId>
        where TId : IEquatable<TId>
    {
        public TId Id { get; set; }
    }
}
