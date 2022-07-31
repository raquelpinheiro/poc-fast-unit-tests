using Poc.Training.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Training.Domain.Interfaces
{
    public interface IRankingService
    {
        Task SortRankig();
        Task<IOrderedEnumerable<Ranking>> GetFirstPositions(int takeRanking);
        Task<IOrderedEnumerable<Ranking>> GetLastPositions(int takeRanking);
        Task<IList<Ranking>> GetAllPositions();
    }
}
