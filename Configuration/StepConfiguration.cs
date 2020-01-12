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
                    Detail = "BEAT eggs, water, salt and pepper in small bowl until blended.",
                    Sequence = 1,
                    MenuId = 1
                },
                new MenuInstruction()
                {
                    Id = 2,
                    Detail = "HEAT butter in 7 to 10-inch nonstick omelet pan or skillet over medium-high heat until hot. TILT pan to coat bottom. POUR IN egg mixture. Mixture should set immediately at edges.",
                    Sequence = 2,
                    MenuId = 1
                },
                new MenuInstruction()
                {
                    Id = 3,
                    Detail = "GENTLY PUSH cooked portions from edges toward the center with inverted turner so that uncooked eggs can reach the hot pan surface. CONTINUE cooking, tilting pan and gently moving cooked portions as needed.",
                    Sequence = 3,
                    MenuId = 1
                },
                new MenuInstruction()
                {
                    Id = 4,
                    Detail = "When top surface of eggs is thickened and no visible liquid egg remains, PLACE filling on one side of the omelet. FOLD omelet in half with turner. With a quick flip of the wrist, turn pan and INVERT or SLIDE omelet onto plate. SERVE immediately.",
                    Sequence = 4,
                    MenuId = 1
                }
            );
        }
    }
}