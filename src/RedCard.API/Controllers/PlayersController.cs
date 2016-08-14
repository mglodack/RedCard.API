using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedCard.API.Contexts;
using RedCard.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedCard.API.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        public PlayersController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        readonly ApplicationDbContext _context;

        [HttpGet(Name = "Index")]
        public IActionResult Index()
        {
            return new ObjectResult(_context.Players.ToList());
        }

        [HttpGet("{id}", Name = "Show")]
        public async Task<IActionResult> ShowAsync(int id)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Id == id);

            if (player == null) { return NotFound();}

            return new ObjectResult(player);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] Player player)
        {
            if (player == null) { return BadRequest(); }

            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return new ObjectResult(player);
        }
    }
}
