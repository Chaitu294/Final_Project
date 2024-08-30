using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Final_Assessment.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AppointmentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var appointments = await _db.Appointment.ToListAsync();
            var customers = await _db.Customer.ToListAsync();

            var appointmentWithCustomerData = appointments.Select(a => new
            {
                Appointment = a,
                CustomerTitle = customers.FirstOrDefault(c => c.CustomerId == a.CustomerId)?.Title
            }).ToList();
            return View(appointments);

        }
        [HttpGet]
        public async Task<IActionResult> Index(string Appsearch)
        {
            ViewData["GetAppointmentDetails"] = Appsearch;
            var empquery = from x in _db.Appointment select x;
            if (!String.IsNullOrEmpty(Appsearch))
            {
                empquery = empquery.Where(x=> x.AppTitle.Contains(Appsearch) || x.Description.Contains(Appsearch));
            }
            return View(await empquery.AsNoTracking().ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "FirstName");
            ViewBag.Tasks = new SelectList(_db.NewTasks, "TaskTitle", "TaskId");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                await _db.Appointment.AddAsync(appointment);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "FirstName", appointment.CustomerId);
            ViewBag.Tasks = new SelectList(_db.NewTasks, "TaskTitle", "TaskId", appointment.TaskId);
            return View(appointment);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var appointment = await _db.Appointment.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "FirstName", appointment.CustomerId);
            ViewBag.Tasks = new SelectList(_db.NewTasks, "TaskTitle", "TaskId", appointment.TaskId);
            return View(appointment);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _db.Update(appointment);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "FirstName", appointment.CustomerId);
            ViewBag.Tasks = new SelectList(_db.NewTasks, "TaskTitle", "TaskId", appointment.TaskId);
            return View(appointment);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var appointment = await _db.Appointment.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var appointment = _db.Appointment.Find(id);
            if (appointment != null)
            {
                _db.Appointment.Remove(appointment);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
