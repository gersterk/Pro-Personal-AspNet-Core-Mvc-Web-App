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


    //contexts are inheriting from DbContext class that EnityFramework Core library prodives
    
    public class Context : IdentityDbContext<AppUser>   //IdentityDbContext Inherits from DbContext... If will use Identity, I have to change to IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   

            //Building Database
            optionsBuilder.UseSqlServer("server = DESKTOP-TLTN1FO;database = ProPersonalDb; integrated security=true");


            //If migration gets a modelcreating error, then

            ///base.OnModelCreating(modelBuilder)


        }



        //to use these entities in the tables 
        //DbSet will be easily used whenever we add a new entity to use
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CommentMail> CommentMails { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet <Newsletter> Newsletters{ get; set; }
        public DbSet <Notification> Notifications{ get; set; }
        
        public DbSet<Admin> Admins { get; set; }
    }
}
