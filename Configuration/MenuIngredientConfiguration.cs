using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_Advice.Configuration
{
    public class MenuIngredientConfiguration : IEntityTypeConfiguration<MenuIngredient>
    {
        public void Configure(EntityTypeBuilder<MenuIngredient> builder)
        {
            builder.ToTable("MenuIngredient");

            builder.HasData(
                new MenuIngredient()
                {
                    MenuId = 1,
                    IngredientId = 1,
                    LongUnit = "eggs",
                    Unit = "eggs",
                    Value = 2
                },
                new MenuIngredient()
                {
                    MenuId = 1,
                    IngredientId = 2,
                    LongUnit = "pinch",
                    Unit = "pinch",
                    Value = 1
                },
                new MenuIngredient()
                {
                    MenuId = 1,
                    IngredientId = 3,
                    LongUnit = "teaspoon",
                    Unit = "tsp",
                    Value = 1
                },
                new MenuIngredient()
                {
                    MenuId = 1,
                    IngredientId = 4,
                    LongUnit = "dash",
                    Unit = "dash",
                    Value = 1
                },
                new MenuIngredient()
                {
                    MenuId = 1,
                    IngredientId = 5,
                    LongUnit = "tablespoon",
                    Unit = "tsp",
                    Value = 2
                },
                new MenuIngredient()
                {
                    MenuId = 1,
                    IngredientId = 6,
                    LongUnit = "cup",
                    Unit = "cup",
                    Value = 0.5
                }
            );
        }
    }
}