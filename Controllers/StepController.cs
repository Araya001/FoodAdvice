using Food_Advice.Models;
using FoodAdvice.Data.EFCore;

namespace FoodAdvice.Controllers
{
    public class StepController : BaseController<Step, EfCoreStepRepository>
    {
        public StepController(EfCoreStepRepository repository) : base(repository)
        {
        }
    }
}