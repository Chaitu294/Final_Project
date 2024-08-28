using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Assessment.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AppointmentsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var appointments = _db.Appointments.ToList();
            return View(appointments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _db.Appointments.Add(appointment);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointment);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var appointment = _db.Appointments.Find(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }


        [HttpPost]
        public IActionResult Edit(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _db.Update(appointment);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointment);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var appointment = _db.Appointments.Find(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }


        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var appointment = _db.Appointments.Find(id);
            if (appointment != null)
            {
                _db.Appointments.Remove(appointment);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
