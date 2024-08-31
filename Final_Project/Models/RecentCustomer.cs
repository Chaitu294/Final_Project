using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class RecentCustomer
    {
        public int RecentCustomerId { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string PreferredName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime ViewedTime { get; set; }
        public string ViewedBy { get; set; }


    }
}
