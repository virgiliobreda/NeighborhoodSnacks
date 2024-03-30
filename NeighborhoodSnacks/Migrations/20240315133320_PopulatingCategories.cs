using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeighborhoodSnacks.Migrations
{
    public partial class PopulatingCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, CategoryDescription) " +
                "VALUES('Normal', 'Snack made with normal ingredients')");

            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, CategoryDescription) " +
                "VALUES('Natual', 'Snacks made with whole, natural ingredients')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories()");
        }
    }
}
