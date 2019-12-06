using System.Collections.Generic;
using System.Threading.Tasks;
using FoodAdvice.Data;
using Microsoft.AspNetCore.Mvc;

namespace FoodAdvice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        protected BaseController(TRepository repository)
        {
            this._repository= repository;
        }
        
        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            return await _repository.GetAll();
        }
        
        // GET: api/[controller]/5
        [HttpGet("{id}" , Name = "Get")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            
            var objects = await _repository.Get(id);
            if (objects == null)
            {
                return NotFound();
            }
            return Ok(objects);
        }
        
        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await _repository.Update(entity);
            return NoContent();
        }
        
        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await _repository.Add(entity);
            return CreatedAtAction("POST", entity.Id,entity);
        }
        
        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var item = await _repository.Delete(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}