using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMenuIngredientRepository : EfCoreRepository<MenuIngredient, FoodAdviceContext>
    {
        public EfCoreMenuIngredientRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}