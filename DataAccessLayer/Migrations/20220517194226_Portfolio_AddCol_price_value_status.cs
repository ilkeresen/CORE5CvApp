using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Portfolio_AddCol_price_value_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PortfolioPrice",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PortfolioStatus",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PortfolioValue",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortfolioPrice",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioStatus",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioValue",
                table: "Portfolios");
        }
    }
}
