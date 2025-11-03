using GroupProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupProject.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasKey(i => i.Id);
            modelBuilder.Entity<Specifications>().HasKey(i => i.Id);
            modelBuilder.Entity<Category>().HasKey(i => i.Id);
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Specifications> Specifications { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
