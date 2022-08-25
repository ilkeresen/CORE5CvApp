using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class filtercoladdportfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceMainHeader",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PortfolioMainHeader",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioFilter",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortfolioFilter",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "ServiceMainHeader",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PortfolioMainHeader",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
