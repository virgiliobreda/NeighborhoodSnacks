using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeighborhoodSnacks.Migrations
{
    public partial class PopulatingSnacks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, SnacksShortDescription, SnacksLongDescription, Stock, ImageThumbnailUrl, ImageUrl, IsFavoriteSnack, SnacksName, SnacksPrice) VALUES(1, 'Bread, hamburger, egg, ham, cheese and straw whisk', 'Hamburger bun with fried egg, prosciutto and top quality cheese', 1, 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0 ,'Cheese Salad', 12.50)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, SnacksShortDescription, SnacksLongDescription, Stock, ImageThumbnailUrl, ImageUrl, IsFavoriteSnack, SnacksName, SnacksPrice) VALUES(1, 'Bread, ham, mozzarella and tomato','Delicious French bread warm with ham and mozzarella well served with tomato.', 1,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',0,'Hot Mix', 8.00)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, SnacksShortDescription, SnacksLongDescription, Stock, ImageThumbnailUrl, ImageUrl, IsFavoriteSnack, SnacksName, SnacksPrice) VALUES(1, 'Bread, Burger, ham, Mozzarella and Straw Battle','Special Bread with Burger, Ham and Mozzarella; Served with shoestring potatoes.', 1,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',0,'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId, SnacksShortDescription, SnacksLongDescription, Stock, ImageThumbnailUrl, ImageUrl, IsFavoriteSnack, SnacksName, SnacksPrice) VALUES(2, 'Bread, white cheese, turkey breast, carrot, lettuce, yogurt','Natural bread, white cheese, turkey breast, carrot, lettuce and natural yoghurt.', 1,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',1,'Natural Snack Turkey Brisket', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Snacks");
        }
    }
}
