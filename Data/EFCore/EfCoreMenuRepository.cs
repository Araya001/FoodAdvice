using System.Linq;
using System.Threading.Tasks;
using Food_Advice.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAdvice.Data.EFCore
{
    public class EfCoreMenuRepository : EfCoreRepository<Menu, FoodAdviceContext>
    {
        public EfCoreMenuRepository(FoodAdviceContext context) : base(context)
        {
        }

        public override async Task<Menu> Get(int id)
        {
            var menu = await _context.Set<Menu>().FindAsync(id);
            var step = _context.Set<Step>().Where(s => s.Menu == menu).AsNoTracking();
            var menuIntegradient = _context.Set<MenuIntegradient>().Where(m => m.Menu == menu).AsNoTracking();
            menu.Steps = step.ToList();
            menu.MenuIntegradients = menuIntegradient.ToList();
            return menu;
        }

        public async Task<Menu> GetMenuWithStep(int id)
        {
            var menu = await _context.Set<Menu>().FindAsync(id);
            var step = _context.Set<Step>().Where(s => s.Menu == menu).AsNoTracking();
            menu.Steps = step.ToList();
            return menu;
        }
    }
}