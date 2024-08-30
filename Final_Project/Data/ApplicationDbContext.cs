using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace Final_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<NewTask> NewTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NewTask>().HasKey(t => t.TaskId);

            builder.Entity<Appointment>().HasKey(a => a.AppId);


            


            base.OnModelCreating(builder);
            //builder.Entity<IdentityUser>().ToTable("Users");
            //builder.Entity<IdentityRole>().ToTable("Roles");
            //builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            //builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            //builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            //builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            //builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");

            builder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1,Title = "Title1",FirstName = "Firstname1",MiddleName = "MiddleName1",Surname = "Surname1",PreferredName = "PreferredName1",Email = "Email1",PhoneNumber=123456,Address = "Address1" },
                new Customer { CustomerId = 2, Title = "Title2", FirstName = "Firstname2", MiddleName = "MiddleName2", Surname = "Surname2", PreferredName = "PreferredName2", Email = "Email2", PhoneNumber = 234567, Address = "Address2" }
                );
            builder.Entity<Appointment>().HasData(
                new Appointment { AppId = 1, AppTitle = "Title1", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2), Description = "Description1", Location = "Location1", Attendees = "Attendee1" },
                new Appointment { AppId = 2, AppTitle = "Title2", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(3), Description = "Description2", Location = "Location2", Attendees = "Attendee2" }
                );

        }
    }
}
