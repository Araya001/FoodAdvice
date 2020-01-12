using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMyCookbookRepository: EfCoreRepository<MyCookbook, FoodAdviceContext>
    {
        public EfCoreMyCookbookRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}