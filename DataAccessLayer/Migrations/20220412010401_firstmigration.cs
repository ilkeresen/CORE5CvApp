using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutComponents",
                columns: table => new
                {
                    AboutComponentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutComponentIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutComponentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutComponentText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutComponents", x => x.AboutComponentID);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMainHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutFirstContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutWebAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutFreelance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutSecondContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    ContactMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactMessageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessageMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessageSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessageContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactMessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.ContactMessageID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactMainHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    HomeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.HomeID);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    InterestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterestName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestID);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioMainHeader = table.Column<int>(type: "int", nullable: false),
                    PortfolioHeader = table.Column<int>(type: "int", nullable: false),
                    PortfolioContent = table.Column<int>(type: "int", nullable: false),
                    PortfolioImageUrl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioID);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeMainHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeFirstContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeSecondContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeThirdContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeFourthContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceMainHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialJob = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutComponents");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
