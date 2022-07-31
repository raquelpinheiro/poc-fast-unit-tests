using Microsoft.EntityFrameworkCore;
using Poc.Training.Domain.Entities;
using Poc.TrainingRunner.Domain.Entities;

namespace Poc.Trainning.Infra.Sql
{
    public class PocTrainingContext : DbContext
    {

        public DbSet< Running> Runnings { get; set; }
        public DbSet<Ranking> Rankings { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public PocTrainingContext(DbContextOptions<PocTrainingContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }
      
    }
}
