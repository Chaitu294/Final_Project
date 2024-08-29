using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public async Task<IActionResult> CustomerManagement(string Customersearch)
        {
            ViewData["GetCustomerDetails"] = Customersearch;
            var customers = from x in _db.Customer 
                           select x;
            if (!String.IsNullOrEmpty(Customersearch))
            {
                customers = customers.Where(x => x.Title.Contains(Customersearch) 
                                            || x.FirstName.Contains(Customersearch) 
                                            || x.MiddleName.Contains(Customersearch) 
                                            || x.Surname.Contains(Customersearch) 
                                            || x.PreferredName.Contains(Customersearch));
            }
            return View(await customers.AsNoTracking().ToListAsync());
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
