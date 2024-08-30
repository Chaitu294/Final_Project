namespace Final_Project.Models
{
    public class Appointment
    {
        public int AppId { get; set; }
        public string AppTitle { get; set; }

        public string Description { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public string Location { get; set; }

        public string Attendees { get; set; }

        public int CustomerId {  get; set; }

        public int TaskId {  get; set; }

       
        
    }
}
