using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Final_Project.Controllers
{
    public class NewTaskController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public NewTaskController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index(string sortOrder, string priorityFilter, string statusFilter, DateTime? startDate, DateTime? endDate)
        {

            ViewBag.DueDateSortParam = string.IsNullOrEmpty(sortOrder) ? "dueDate_desc" : "";
            ViewBag.PrioritySortParam = sortOrder == "Priority" ? "priority_desc" : "Priority";
            ViewBag.StatusSortParam = sortOrder == "Status" ? "status_desc" : "Status";

            var tasks = from t in _db.NewTasks select t;

            // Filtering
            if (!string.IsNullOrEmpty(priorityFilter))
            {
                if (Enum.TryParse(priorityFilter, out Priority priorityEnum))
                {
                    tasks = tasks.Where(t => t.Priority == priorityEnum);
                }
            }

            if (!string.IsNullOrEmpty(statusFilter))
            {
                if (Enum.TryParse(statusFilter, out Status statusEnum))
                {
                    tasks = tasks.Where(t => t.Status == statusEnum);
                }
            }

            if (startDate.HasValue && endDate.HasValue)
            {
                tasks = tasks.Where(t => t.DueDateTime >= startDate.Value && t.DueDateTime <= endDate.Value);
            }

            // Sorting
            switch (sortOrder)
            {
                case "dueDate_desc":
                    tasks = tasks.OrderByDescending(t => t.DueDateTime);
                    break;
                case "Priority":
                    tasks = tasks.OrderBy(t => t.Priority);
                    break;
                case "priority_desc":
                    tasks = tasks.OrderByDescending(t => t.Priority);
                    break;
                case "Status":
                    tasks = tasks.OrderBy(t => t.Status);
                    break;
                case "status_desc":
                    tasks = tasks.OrderByDescending(t => t.Status);
                    break;
                default:
                    tasks = tasks.OrderBy(t => t.DueDateTime);
                    break;
            }

            return View(tasks.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Users = new SelectList(_userManager.Users, "FirstName", "UserName");
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(NewTask obj)
        {
            if (ModelState.IsValid)
            {
                _db.NewTasks.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Users = new SelectList(_userManager.Users, "FirstName", "UserName", obj.AssignedTo);
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "Title", obj.CustomerId);
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = _db.NewTasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }
            ViewBag.Users = new SelectList(_userManager.Users, "FirstName", "UserName", task.AssignedTo);
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "Title", task.CustomerId);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(NewTask task)
        {
            if (ModelState.IsValid)
            {
                _db.Update(task);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Users = new SelectList(_userManager.Users, "FirstName", "UserName",task.AssignedTo);
            ViewBag.Customers = new SelectList(_db.Customer, "CustomerId", "Title", task.CustomerId);
            return View(task);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var task = _db.NewTasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var task = _db.NewTasks.Find(id);
            if (task != null)
            {
                _db.NewTasks.Remove(task);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
