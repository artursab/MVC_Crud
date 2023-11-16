using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_CRud.Models;

namespace MVC_CRud.Data
{
    public class MVC_CRudContext : DbContext
    {
        public MVC_CRudContext (DbContextOptions<MVC_CRudContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_CRud.Models.Movie> Movie { get; set; } = default!;
    }
}
