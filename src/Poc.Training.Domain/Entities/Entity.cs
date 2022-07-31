using System;

namespace Poc.Training.Domain.Entities
{
    public abstract class Entity
    {
        public long Id { get; set; }
        public DateTimeOffset DateTimeAdd { get; set; }
        public DateTimeOffset DateTimeUpdate { get; set; }
    }
}
