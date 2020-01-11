using Food_Advice.Models;
using FoodAdvice.Data.EFCore;
using Microsoft.AspNetCore.Mvc;

namespace FoodAdvice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : BaseController<Ingredirnt, EfCoreIngredientRepository>
    {
        public IngredientController(EfCoreIngredientRepository repository) : base(repository)
        {
        }
    }
}