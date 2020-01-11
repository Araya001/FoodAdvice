using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_Advice.Configuration
{
    public class StepConfiguration : IEntityTypeConfiguration<MenuInstruction>
    {
        public void Configure(EntityTypeBuilder<MenuInstruction> builder)
        {
            builder.ToTable("MenuInstruction");
 
            builder.HasData
            (
                new MenuInstruction()
                {
                    Id = 1,
                    Detail = "1. ตอกไข่ใส่ชาม",
                   // Description = "",
                    MenuId = 1
                },
                new MenuInstruction()
                {
                    Id = 2,
                    Detail = "2. เจียวไข่ให้ขึ้นฟอง",
                  //  Description = "",
                    MenuId = 1
                }
            );
        }
    }
}