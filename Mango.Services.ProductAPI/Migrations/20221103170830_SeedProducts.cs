using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Hmmmmm....it's a description", "https://www.cookwithnabeela.com/wp-content/uploads/2021/08/Aloo_Samosa_Web_1-768x432.jpg", "Samosa", 15.0 },
                    { 2, "Appetizer", "Hmmmmm....it's a description", "https://www.archanaskitchen.com/images/archanaskitchen/1-Author/Neha_Mathur/Achari_Paneer_Tikka_Recipe_Party_Food.JPG", "Paneer Tikka", 13.99 },
                    { 3, "Dessert", "Hmmmmm....it's a description", "https://img.taste.com.au/Rg1vZtV-/w643-h428-cfill-q90/taste/2016/11/doreens-lemon-meringue-pie-109813-1.jpeg", "Sweet pie", 10.99 },
                    { 4, "Entree", "Hmmmmm....it's a description", "https://i0.wp.com/s3.ap-south-1.amazonaws.com/images.salonyscookbook.com/pav-bhaji-recipe/pav-bhaji-recipe13.jpg?w=1200", "Pav Bhaji", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
