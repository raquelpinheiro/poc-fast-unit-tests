using Poc.Training.Domain.Entities;
using Poc.Training.Domain.Interfaces;

namespace Poc.Training.Domain.Services
{
    public class RankingService : IRankingService
    {
        public Task<IList<Ranking>> GetAllPositions()
        {
            throw new NotImplementedException();
        }

        public Task<IOrderedEnumerable<Ranking>> GetFirstPositions(int takeRanking)
        {
            throw new NotImplementedException();
        }

        public Task<IOrderedEnumerable<Ranking>> GetLastPositions(int takeRanking)
        {
            throw new NotImplementedException();
        }

        public Task SortRankig()
        {
            throw new NotImplementedException();
        }
    }
}
