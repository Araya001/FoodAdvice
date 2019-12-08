using System.Threading.Tasks;
using Food_Advice.Models;
using FoodAdvice.Data.EFCore;
using Microsoft.AspNetCore.Mvc;

namespace FoodAdvice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : BaseController<Menu, EfCoreMenuRepository>
    {
        private readonly EfCoreMenuRepository _repository;
        private readonly EfCoreStepRepository _stepRepository;
        public MenuController(EfCoreMenuRepository repository, EfCoreStepRepository stepRepository) : base(repository)
        {
            this._repository = repository;
            _stepRepository = stepRepository;
        }
    }
}