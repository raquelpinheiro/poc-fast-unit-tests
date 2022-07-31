using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Poc.Training.Domain.Interfaces;

namespace Poc.Trainning.Infra.Sql
{
    public static class ServiceExtensions
    {
        private static readonly string DbPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "blogging.db");

        public static IServiceCollection AddSqlLiteDataBase(this IServiceCollection services)
        {
            services.AddDbContext<PocTrainingContext>(opt =>
            {
                opt.UseSqlite($"Data Souce={DbPath}");
            });

            return services;
        }

        public static IServiceCollection AddSqlRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITrainingRepository, TrainingRepository>();
            services.AddTransient<IRankingRepository, RankingRepository>();

            return services;
        }      
     
    }
}
