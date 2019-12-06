using System;
using System.Threading;
using System.Threading.Tasks;
using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAdvice.Data
{
    public class FoodAdviceContext : DbContext
    {
        //Config Appcontext
        public FoodAdviceContext(DbContextOptions<FoodAdviceContext> options) : base(options)
        {
        }
        
        //Cofig Model
        public DbSet<Menu> Menus { get; set; }
        
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.Entity is IEntity baseModel)
                {
                    var now = DateTime.UtcNow;
                    var user = GetCurrentUser();
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            baseModel.LastUpdatedAt = now;
                            baseModel.LastUpdatedBy = user;
                            break;

                        case EntityState.Added:
                            baseModel.CreatedAt = now;
                            baseModel.CreatedBy = user;
                            baseModel.LastUpdatedAt = now;
                            baseModel.LastUpdatedBy = user;
                            break;
                    }
                }
            }
        }

        private string GetCurrentUser()
        {
            return "FoodAdmin"; // TODO implement your own logic

            // If you are using ASP.NET Core, you should look at this answer on StackOverflow
            // https://stackoverflow.com/a/48554738/2996339
        }
    }
}