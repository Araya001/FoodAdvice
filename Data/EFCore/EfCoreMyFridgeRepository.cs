using Food_Advice.Models;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMyFridgeRepository: EfCoreRepository<MyFridge, FoodAdviceContext>
    {
        public EfCoreMyFridgeRepository(FoodAdviceContext context) : base(context)
        {
        }
    }
}