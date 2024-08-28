namespace Final_Project.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PhotoPath { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
