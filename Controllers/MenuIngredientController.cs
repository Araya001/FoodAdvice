using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class MenuIngredientController : BaseController<MenuIngredient, EfCoreMenuIngredientRepository>
    {
        public MenuIngredientController(EfCoreMenuIngredientRepository repository) : base(repository)
        {
        }
    }
}