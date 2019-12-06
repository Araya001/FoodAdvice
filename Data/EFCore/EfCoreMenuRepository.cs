using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMenuRepository : EfCoreRepository<Menu, FoodAdviceContext>
    {
        public EfCoreMenuRepository(FoodAdviceContext context) : base(context)
        {
        }
        // We can add new methods specific to the movie repository here in the future
    }
}