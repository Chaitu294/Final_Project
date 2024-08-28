using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        public DbSet<NewTask> NewTasks { get; set; }

        public DbSet<Appointment>  Appointments { get; set; }
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

            builder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "User1", PhotoPath = "~/Images/john.png", Created = DateTime.Now },
                new User { UserId = 2, UserName = "User2", PhotoPath = "~/Images/mary.png", Created = DateTime.Now }
                );
            builder.Entity<Appointment>().HasData(
                new Appointment { AppId = 1, AppTitle = "Title1", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2), Description = "Description1", Location = "Location1", Attendees = "Attendee1" },
                new Appointment { AppId = 2, AppTitle = "Title2", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(3), Description = "Description2", Location = "Location2", Attendees = "Attendee2" }
                );

        }
    }
}
