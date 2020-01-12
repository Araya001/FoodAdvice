using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreUserRepository :EfCoreRepository<User, FoodAdviceContext>
    {
        public EfCoreUserRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}