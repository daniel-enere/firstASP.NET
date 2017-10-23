using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace First.NETwebApplication.Models
{
    public class FirstNETwebApplicationContext : DbContext
    {
        public FirstNETwebApplicationContext (DbContextOptions<FirstNETwebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<First.NETwebApplication.Models.Movie> Movie { get; set; }
    }
}
