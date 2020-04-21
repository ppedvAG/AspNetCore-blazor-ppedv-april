using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_MVC_EF.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Blog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
