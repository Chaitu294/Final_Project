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
        [HttpPost]
        public IActionResult CreateNewLead(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customer.Add(customer);
                _db.SaveChanges();
                return RedirectToAction();
            }
            return View(customer);
        }
        public IActionResult CustomerManagement()
        {
            List<Customer> customerlist = _db.Customer.ToList();
            return View(customerlist);
        }

        public IActionResult CustomerView(int id)
        {
            var customer = _db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        public IActionResult CustomerEdit(int id)
        {
            var customer = _db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }


        [HttpPost]
        public IActionResult CustomerEdit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Update(customer);
                _db.SaveChanges();
                return RedirectToAction();
            }
            return View(customer);
        }


        public IActionResult CustomerRemove(int id)
        {
            var customer = _db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }


        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var customer = _db.Customer.Find(id);
            if (customer != null)
            {
                _db.Customer.Remove(customer);
                _db.SaveChanges();
            }
            return RedirectToAction("CustomerManagement");
        }

    }
}
