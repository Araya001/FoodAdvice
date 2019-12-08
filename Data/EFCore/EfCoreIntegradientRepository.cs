using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreIntegradientRepository : EfCoreRepository<Integradient, FoodAdviceContext>
    {
        public EfCoreIntegradientRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}