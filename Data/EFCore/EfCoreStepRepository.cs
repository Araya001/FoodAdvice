using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreStepRepository : EfCoreRepository<Step, FoodAdviceContext>
    {
        public EfCoreStepRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}