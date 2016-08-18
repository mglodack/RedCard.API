using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedCard.API.Contexts;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RedCard.API.Controllers
{
    [Route("api/[controller]")]
    public class StatsController : Controller
    {
        public StatsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        readonly ApplicationDbContext _dbContext;

        [HttpGet]
        public IActionResult RedCardCountForCountry()
        {
            var redCardCount = _dbContext.Players
                .GroupBy(player => player.Country)
                .Select(grouping => new { country = grouping.Key, redCardCount = grouping.Sum(player => player.RedCards) })
                .ToArray();

            return new ObjectResult(new { redCardCountForCountry = redCardCount });
        }
    }
}
