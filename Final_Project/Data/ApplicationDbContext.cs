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
        }
    }
}
