using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class MyFridgeController: BaseController<MyFridge, EfCoreMyFridgeRepository>
    {
        public MyFridgeController(EfCoreMyFridgeRepository repository) : base(repository)
        {
        }
    }
}