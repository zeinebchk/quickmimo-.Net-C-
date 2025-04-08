using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using quickmimo.context;

namespace quickmimo
{
    public static  class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRecipeNoteBookDataService(this IServiceCollection services)
        {
            services.AddDbContext<DBMimoContext>(
               Options =>
               {
                   Options.UseSqlite("DataSource=recipes.db");
                   //utiliser seeding pour initialiser la base de donnee avec les donnes de test
                   //Options.UseSeeding((context, _) =>
                   //{
                   //    (context as DBMimoContext).Seed();
                   //});
               },
               //utiliser transient pour eviter les problemes de scope dans winforms
               ServiceLifetime.Transient
               );
            services.AddTransient<Repositories.RecipeRepository>();
            services.AddTransient<Repositories.CategoryRepository>();
            return services;
        }
        public static void ApplyMigrationsForRecipeNoteBookDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<RecipeContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
}
