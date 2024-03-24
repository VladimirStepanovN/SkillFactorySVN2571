using Microsoft.EntityFrameworkCore;
using SkillFactorySVN2571.DataAccessLayer.Entity;

namespace SkillFactorySVN2571.DataAccessLayer.DB
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new DBConnection().GetConnectionString());
        }
    }
}
