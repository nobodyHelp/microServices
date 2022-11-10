using Mango.Services.ProductAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mango.Services.ProductAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Hmmmmm....it's a description",
                ImageUrl = "https://www.cookwithnabeela.com/wp-content/uploads/2021/08/Aloo_Samosa_Web_1-768x432.jpg",
                CategoryName = "Appetizer"
            }
            );
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Hmmmmm....it's a description",
                ImageUrl = "https://www.archanaskitchen.com/images/archanaskitchen/1-Author/Neha_Mathur/Achari_Paneer_Tikka_Recipe_Party_Food.JPG",
                CategoryName = "Appetizer"
            }
            );
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet pie",
                Price = 10.99,
                Description = "Hmmmmm....it's a description",
                ImageUrl = "https://img.taste.com.au/Rg1vZtV-/w643-h428-cfill-q90/taste/2016/11/doreens-lemon-meringue-pie-109813-1.jpeg",
                CategoryName = "Dessert"
            }
            );
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Hmmmmm....it's a description",
                ImageUrl = "https://i0.wp.com/s3.ap-south-1.amazonaws.com/images.salonyscookbook.com/pav-bhaji-recipe/pav-bhaji-recipe13.jpg?w=1200",
                CategoryName = "Entree"
            }
            );
        }
    }
}
