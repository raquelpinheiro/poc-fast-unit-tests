using Poc.Training.Domain.Entities;
using Poc.TrainingRunner.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poc.Training.Domain.Interfaces
{
    public interface ITrainingService
    {
        Task Add(Running training);
        Task Update(Running training);
    }
}
