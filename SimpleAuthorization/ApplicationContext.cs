using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleAuthorization.Models;

namespace SimpleAuthorization
{
    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<User> Users => Set<User>();

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationContext()
        {

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=MyDb.db");
        }
    }
}
