using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class resume_update_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResumeFirstContent",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ResumeFourthContent",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ResumeSecondContent",
                table: "Resumes");

            migrationBuilder.RenameColumn(
                name: "ResumeThirdContent",
                table: "Resumes",
                newName: "ResumeContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResumeContent",
                table: "Resumes",
                newName: "ResumeThirdContent");

            migrationBuilder.AddColumn<string>(
                name: "ResumeFirstContent",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeFourthContent",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeSecondContent",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
