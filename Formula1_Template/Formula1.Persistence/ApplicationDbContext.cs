using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1.Core.Entities;

namespace Formula1.Persistence
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Driver> Drivers { get; set; }
    }
}
