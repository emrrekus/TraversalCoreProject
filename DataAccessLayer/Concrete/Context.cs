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
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S74UGVJ;database=TraversalCoreProject;integrated security=true;TrustServerCertificate=True");

        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet <Guide> Guides { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SecondaryAbout> SecondaryAbouts { get; set; }

        public DbSet<SecondaryFeature> SecondaryFeatures { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
