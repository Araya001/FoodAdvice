using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreIngredientRepository : EfCoreRepository<Ingredirnt, FoodAdviceContext>
    {
        public EfCoreIngredientRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}