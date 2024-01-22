using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    //DbContext is for ORM
    public class ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options
    ) : DbContext(options) // CLass inherits from DbContext class
    {
        // file is For CRUD
        public DbSet<Category> Categories { get; set; } // Table
        //public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = "1" },
                new Category { Id = 2, Name = "Sci fi", DisplayOrder = "2" }
            );

            //modelBuilder.Entity<Products>().HasData(
        }
    }
}
