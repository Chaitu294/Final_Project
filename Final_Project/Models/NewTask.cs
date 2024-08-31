using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class NewTask
    {
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Task Title is required")]
        public string TaskTitle { get; set; }

        [Required(ErrorMessage = "Client Name is required")]
        public string ClientName { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "DueDateTime is required")]
        public DateTime DueDateTime { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        public Priority Priority { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public Status Status { get; set; }

        public string AssignedTo {  get; set; }

        public int? CustomerId { get; set; }

        


        

    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
    public enum Status
    {
        NotStarted,
        InProgress,
        Completed
    }

}
