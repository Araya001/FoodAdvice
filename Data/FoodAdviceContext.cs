using System;
using System.Threading;
using System.Threading.Tasks;
using Food_Advice.Configuration;
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
        public DbSet<Ingredirnt> Ingredients { get; set; }
        public DbSet<MenuIngredient> MenuIngredients { get; set; }
        public DbSet<MenuInstruction> Steps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuIngredient>()
                .HasKey(t => new {t.MenuId, IntegradientId = t.IngredientId});

            modelBuilder.Entity<MenuIngredient>()
                .HasOne<Menu>(m => m.Menu)
                .WithMany(mi => mi.MenuIntegradients)
                .HasForeignKey(m => m.MenuId);

            modelBuilder.Entity<MenuIngredient>()
                .HasOne<Ingredirnt>(i => i.Ingredient)
                .WithMany(mi => mi.MenuIntegradients)
                .HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<MenuInstruction>()
                .HasOne<Menu>(s => s.Menu)
                .WithMany(m => m.Steps)
                .HasForeignKey(s => s.MenuId);

            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new IntegradientConfiguration());
            modelBuilder.ApplyConfiguration(new StepConfiguration());
            base.OnModelCreating(modelBuilder);
        }

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