using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_Advice.Configuration
{
    public class StepConfiguration : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.ToTable("Step");
 
            builder.HasData
            (
                new Step()
                {
                    Id = 1,
                    Detail = "1. ตอกไข่ใส่ชาม",
                    Description = "",
                    MenuId = 1
                },
                new Step()
                {
                    Id = 2,
                    Detail = "2. เจียวไข่ให้ขึ้นฟอง",
                    Description = "",
                    MenuId = 1
                }
            );
        }
    }
}