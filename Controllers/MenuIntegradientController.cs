using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class MenuIntegradientController : BaseController<MenuIntegradient, EfCoreMenuIntegradientRepository>
    {
        public MenuIntegradientController(EfCoreMenuIntegradientRepository repository) : base(repository)
        {
        }
    }
}