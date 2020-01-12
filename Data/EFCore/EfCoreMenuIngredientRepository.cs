using System.Linq;
using System.Threading.Tasks;
using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMenuIngredientRepository : EfCoreRepository<MenuIngredient, FoodAdviceContext>
    {
        public EfCoreMenuIngredientRepository(FoodAdviceContext context) : base(context)
        {
        }
        
        public override async Task<MenuIngredient> Get(int id)
        {
            var menu = await _context.Set<MenuIngredient>().Where(m => m.IngredientId == id).FirstOrDefaultAsync();
            return menu;
        }
    }
}