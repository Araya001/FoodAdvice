using Food_Advice.Models;
using FoodAdvice.Data.EFCore;
using Microsoft.AspNetCore.Mvc;

namespace FoodAdvice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegradientController : BaseController<Integradient, EfCoreIntegradientRepository>
    {
        public IntegradientController(EfCoreIntegradientRepository repository) : base(repository)
        {
        }
    }
}