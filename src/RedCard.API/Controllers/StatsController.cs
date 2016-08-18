using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedCard.API.Contexts;
using RedCard.API.Models;

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

        [Route("redcards")]
        [HttpGet]
        public IActionResult RedCardCountForCountry()
        {
            Func<IGrouping<string, Player>, object> getRedCardsForCountry =
                (grouping) => new { country = grouping.Key, redCardCount = grouping.Sum(player => player.RedCards) };

            var redCardCount = _CardsForCountry(getRedCardsForCountry);

            return new ObjectResult(new { redCardCountForCountry = redCardCount });
        }

        [Route("yellowcards")]
        [HttpGet]
        public IActionResult YellowCardCountForCountry()
        {
            Func<IGrouping<string, Player>, object> getYellowCardsForCountry =
                (grouping) => new { country = grouping.Key, yellowCardCount = grouping.Sum(player => player.YellowCards) };

            var yellowCardCount = _CardsForCountry(getYellowCardsForCountry);

            return new ObjectResult(new { yellowCardCountForCountry = yellowCardCount });
        }

        IEnumerable<object> _CardsForCountry(Func<IGrouping<string, Player>, object> getInfo)
        {
            return _dbContext.Players
                .GroupBy(player => player.Country)
                .Select(getInfo)
                .ToArray();
        }
    }
}
