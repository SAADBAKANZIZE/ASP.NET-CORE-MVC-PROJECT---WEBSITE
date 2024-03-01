
using Bulky.Models;
using Microsoft.EntityFrameworkCore;
 
namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Category> categories { get; set; }

        public DbSet<Product> products { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
        //        new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
        //        new Category { Id = 3, Name = "History", DisplayOrder = 3 },
        //        new Category { Id = 4, Name = "Documentary", DisplayOrder = 4 }

        //        );


        //}



    }
}
