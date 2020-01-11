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
        private readonly EfCoreMenuInstructionRepository _menuInstructionRepository;
        public MenuController(EfCoreMenuRepository repository, EfCoreMenuInstructionRepository menuInstructionRepository) : base(repository)
        {
            this._repository = repository;
            _menuInstructionRepository = menuInstructionRepository;
        }
        
        // GET: api/[controller]/5
        [HttpGet("{GetMenuByName}/{name}")]
        public virtual async Task<ActionResult<Menu>> GetMenuByName(string name)
        {

            var objects = await _repository.GetMenuByName(name);
            if (objects == null)
            {
                return NotFound();
            }
            return Ok(objects);
        }
    }
}