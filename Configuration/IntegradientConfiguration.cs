using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_Advice.Configuration
{
    public class IntegradientConfiguration : IEntityTypeConfiguration<Ingredirnt>
    {
        public void Configure(EntityTypeBuilder<Ingredirnt> builder)
        {
            builder.ToTable("Ingredient");
 
            builder.HasData
            (
                new Ingredirnt()
                {
                    Id = 1,
                    //Title = "Egg",
                    //NameTh = "ไข่ไก่",
                    //NameEn = "Eggs",
                    //Description = "ไข่ไก่ มาจากไก่",
                    Type = ""
                },
                new Ingredirnt()
                {
                    Id = 2,
                    //Title = "Fish sauce",
                    //NameTh = "น้ำปลา",
                    //NameEn = "Fish sauce",
                    //Description = "น้ำปลา",
                    Type = ""
                }
            );
        }
    }
}