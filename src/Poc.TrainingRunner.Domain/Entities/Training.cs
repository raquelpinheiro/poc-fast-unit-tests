using System;

namespace Poc.TrainingRunner.Domain.Entities
{
    public class Training
    {
        public TimeSpan DuringTime { get; set; }

        public DayOfWeek Day { get; set; }

        public DateTime Date { get; set; }
    }
}
