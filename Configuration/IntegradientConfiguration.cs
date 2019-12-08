using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_Advice.Configuration
{
    public class IntegradientConfiguration : IEntityTypeConfiguration<Integradient>
    {
        public void Configure(EntityTypeBuilder<Integradient> builder)
        {
            builder.ToTable("Integradient");
 
            builder.HasData
            (
                new Integradient()
                {
                    Id = 1,
                    Title = "Egg",
                    NameTh = "ไข่ไก่",
                    NameEn = "Eggs",
                    Description = "ไข่ไก่ มาจากไก่",
                    Type = ""
                },
                new Integradient()
                {
                    Id = 2,
                    Title = "Fish sauce",
                    NameTh = "น้ำปลา",
                    NameEn = "Fish sauce",
                    Description = "น้ำปลา",
                    Type = ""
                }
            );
        }
    }
}