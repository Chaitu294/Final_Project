using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }

    }
}
