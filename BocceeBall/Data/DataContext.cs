using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocceeBall.Data
{
    class DataContext : DbContext 
    {
        public DataContext() :base("name=DefaultConnection")
        {

        }

        public DbSet<Teams> Teams { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Players> Players { get; set; }
    }
}
