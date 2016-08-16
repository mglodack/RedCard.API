using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using RedCard.API.Contexts;
using Microsoft.EntityFrameworkCore;

namespace RedCard.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
              context.Database.Migrate();
            }

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
