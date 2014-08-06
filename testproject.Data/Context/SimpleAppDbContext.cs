using SimpleApp.Data.Entities;
using SimpleApp.Data.Initializer;
using System.Data.Entity;

namespace SimpleApp.Data.Context
{
    public class SimpleAppDbContext : DbContext
    {
        public SimpleAppDbContext()
            : base("SimpleApp.DbConnection")
        {
            Database.SetInitializer<SimpleAppDbContext>(new SimpleAppInitializer());
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<TestUser> TestUsers { get; set; }
    }
}
