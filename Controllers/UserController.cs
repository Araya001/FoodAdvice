using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class UserController : BaseController<User, EfCoreUserRepository>
    {
        public UserController(EfCoreUserRepository repository) : base(repository)
        {
        }
    }
}