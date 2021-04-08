using Microsoft.EntityFrameworkCore.Migrations;

namespace castle_web.Data.Migrations
{
    public partial class viewsadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Views",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "AspNetUsers");
        }
    }
}
