using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("server=DESKTOP-JSCTA9J\\SQLEXPRESS;database=CoreCvDb;integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutComponent> AboutComponents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WriterMessage> WriterMessages { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
