using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMenuIntegradientRepository : EfCoreRepository<MenuIntegradient, FoodAdviceContext>
    {
        public EfCoreMenuIntegradientRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}