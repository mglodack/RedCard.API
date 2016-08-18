using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedCard.API.Contexts;
using RedCard.API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RedCard.API.Controllers
{
    [Route("[controller]")]
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
