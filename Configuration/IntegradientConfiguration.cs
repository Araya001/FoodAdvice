using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_Advice.Configuration
{
    public class IntegradientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable("Ingredient");
 
            builder.HasData
            (
                new Ingredient()
                {
                    Id = 1,
                    Name = "Egg",
                    Type = "Egg"
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Salt",
                    Type = "Seasoning"
                },
                new Ingredient()
                {
                    Id = 3,
                    Name = "Butter",
                    Type = "Material"
                },
                new Ingredient()
                {
                    Id = 4,
                    Name = "Pepper",
                    Type = "Seasoning"
                },
                new Ingredient()
                {
                    Id = 5,
                    Name = "Water",
                    Type = "Material"
                },
                new Ingredient()
                {
                    Id = 6,
                    Name = "Shredded Cheese",
                    Type = "Cheese"
                }
            );
        }
    }
}