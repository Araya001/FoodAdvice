using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMenuInstructionRepository : EfCoreRepository<MenuInstruction, FoodAdviceContext>
    {
        public EfCoreMenuInstructionRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}