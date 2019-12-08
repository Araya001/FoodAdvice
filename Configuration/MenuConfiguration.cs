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
                    Title = "Omelette",
                    NameTh = "ข้าวไข่เจียว",
                    NameEn = "Minced Pork Omelette",
                    Description = "ข้าวไข่เจียว เป็นอาหารที่ทำง่ายๆ ใครๆก็สามารถทำกินได้แถมรสชาติดี",
                    Type = "fired"
                }
            );
        }
    }
}