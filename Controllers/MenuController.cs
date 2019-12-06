using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class MenuController : BaseController<Menu, EfCoreMenuRepository>
    {
        public MenuController(EfCoreMenuRepository repository) : base(repository)
        {
        }
    }
}