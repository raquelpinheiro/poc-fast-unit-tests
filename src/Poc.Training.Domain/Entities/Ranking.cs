using Poc.TrainingRunner.Domain.Entities;

namespace Poc.Training.Domain.Entities
{
    public class Ranking : Entity
    {
        public int Position { get; set; }
        public Running Running { get; set; }

        public bool IsValidToAdd()
        {
            return Position > 0 && Position < int.MaxValue && 
                   Running != null && Running.Id > 0;
        }
    }
}
