using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class MenuInstructionController : BaseController<MenuInstruction, EfCoreMenuInstructionRepository>
    {
        public MenuInstructionController(EfCoreMenuInstructionRepository repository) : base(repository)
        {
        }
    }
}