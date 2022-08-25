﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220419220528_resume_update_model")]
    partial class resume_update_model
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutFirstContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutFreelance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutMainHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutSecondContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutWebAdress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AboutComponent", b =>
                {
                    b.Property<int>("AboutComponentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutComponentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutComponentIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutComponentText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutComponentID");

                    b.ToTable("AboutComponents");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMainHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ContactMessage", b =>
                {
                    b.Property<int>("ContactMessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ContactMessageApproval")
                        .HasColumnType("bit");

                    b.Property<string>("ContactMessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContactMessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactMessageMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactMessageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContactMessageSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactMessageID");

                    b.ToTable("ContactMessages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Home", b =>
                {
                    b.Property<int>("HomeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HomeContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HomeID");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Interest", b =>
                {
                    b.Property<int>("InterestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InterestColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterestID");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Portfolio", b =>
                {
                    b.Property<int>("PortfolioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PortfolioContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioFilter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PortfolioID");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Resume", b =>
                {
                    b.Property<int>("ResumeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ResumeAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeMainHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResumeID");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceIcon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SocialMediaIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMediaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SocialMediaStatus")
                        .HasColumnType("bit");

                    b.Property<string>("SocialMediaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaID");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Testimonial", b =>
                {
                    b.Property<int>("TestimonialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TestimonialContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestimonialID");

                    b.ToTable("Testimonials");
                });
#pragma warning restore 612, 618
        }
    }
}
