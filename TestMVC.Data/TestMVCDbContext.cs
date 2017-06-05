using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVC.Model;

namespace TestMVC.Data
{
    public class TestMVCDbContext : DbContext
    {
        public TestMVCDbContext() : base("TestMVC5")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Error> Errors { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
