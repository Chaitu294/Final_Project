using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Assessment.Controllers
{
    public class HomeDashboardController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeDashboardController(ApplicationDbContext db)
        { 
            _db = db; 
        }
        public IActionResult CreateNewLead()
        {
            return View();
        }
        public IActionResult AppointmentManagement()
        {
            List<Appointment> appointmentlist = _db.Appointment.ToList();
            return View(appointmentlist);
        }
        public IActionResult CreateNewAppointment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewAppointment(Appointment obj)
        {
            _db.Appointment.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("AppointmentManagement", "HomeDashboard");
        }
        public IActionResult UserManagement()
        {
            List<User> userlist = _db.User.ToList();
            return View(userlist);
        }
    }
}
