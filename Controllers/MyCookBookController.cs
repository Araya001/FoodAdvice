using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class MyCookBookController: BaseController<MyCookbook, EfCoreMyCookbookRepository>
    {
        public MyCookBookController(EfCoreMyCookbookRepository repository) : base(repository)
        {
        }
    }
}