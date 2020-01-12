using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_Advice.Configuration
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
 
            builder.HasData
            (
                new Menu()
                {
                    Id = 1,
                   Description = "The omelette is one of the easiest and most inexpensive meals, and it works beautifully for breakfast, lunch or dinner.",
                   Name = "Omelette",
                   Servings = 1,
                   ReadyInMinutes = 10
                }
            );
        }
    }
}