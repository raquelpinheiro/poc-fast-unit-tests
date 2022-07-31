using Poc.Training.Domain.Entities;
using System;

namespace Poc.TrainingRunner.Domain.Entities
{
    public class Running : Entity
    {
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public DayOfWeek Day { get; set; }
        public DateTimeOffset DateTime { get; set; }

        public bool IsValidToAdd()
        {
            return string.IsNullOrWhiteSpace(Description) &&
                        Duration > TimeSpan.Zero &&
                        Duration > TimeSpan.MinValue &&
                        DateTimeIsValidToAdd();
        }

        private bool DateTimeIsValidToAdd()
        {
            return DateTime > DateTimeOffset.MinValue &&
                       DateTime < DateTimeOffset.MaxValue &&
                       DateTime > DateTimeOffset.UtcNow;
        }
    }
}
