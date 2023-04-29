using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial.API.Data;
using Parcial.Shared.Entities;

namespace Parcial.API.Controllers
{
    [ApiController]
    [Route("/api/entrances")]
    public class EntrancesController : ControllerBase
    {
        private readonly DataContext _context;

        public EntrancesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok( await _context.Entrances.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var entrance = await _context.Entrances.FirstOrDefaultAsync(X => X.Id == id);
            if (entrance == null)
            {
                return NotFound();
            }
            return Ok(entrance);
        }


        [HttpPost]
        public async Task<ActionResult> PostAsync(Entrance entrance)
        {
            _context.Add(entrance);
            await _context.SaveChangesAsync();
            return Ok(entrance);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Entrance entrance)
        {
            _context.Update(entrance);
            await _context.SaveChangesAsync();
            return Ok(entrance);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entrance = await _context.Entrances.FirstOrDefaultAsync(X => X.Id == id);
            if (entrance == null)
            {
                return NotFound();
            }
            _context.Remove(entrance);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}


