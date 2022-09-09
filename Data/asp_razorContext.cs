using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp_razor.Models;

namespace asp_razor.Data
{
    public class asp_razorContext : DbContext
    {
        public asp_razorContext (DbContextOptions<asp_razorContext> options)
            : base(options)
        {
        }

        public DbSet<asp_razor.Models.Movie> Movie { get; set; } = default!;
    }
}
