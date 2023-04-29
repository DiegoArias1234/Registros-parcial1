using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial.API.Data;
using Parcial.Shared.Entities;

namespace Parcial.API.Controllers
{
    [ApiController]
    [Route("/api/entrances")]
    public class EntrancesControllers : ControllerBase
    {
        private readonly DataContext _context;

        public EntrancesControllers(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok( await _context.Entrances.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Entrance entrance)
        {
            _context.Add(entrance);
            await _context.SaveChangesAsync();
            return Ok(entrance);
        }
    }
}
