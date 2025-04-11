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
        public static IServiceCollection AddMimoNoteBookDataService(this IServiceCollection services)
        {
            services.AddDbContext<DBMimoContext>(
               Options =>
               {
                   Options.UseSqlite("DataSource=mimo.db");
                   //utiliser seeding pour initialiser la base de donnee avec les donnes de test
                   //Options.UseSeeding((context, _) =>
                   //{
                   //    (context as DBMimoContext).Seed();
                   //});
               },
               //utiliser transient pour eviter les problemes de scope dans winforms
               ServiceLifetime.Transient
               );
            services.AddTransient<Repositories.UserRepository>();
            services.AddTransient<Repositories.CategoryRepository>();
            services.AddTransient<Repositories.NoteRepository>();
            services.AddTransient<Repositories.TaskRepository>();
            return services;
        }
        public static void ApplyMigrationsForMimoNoteBookDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<DBMimoContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
}
