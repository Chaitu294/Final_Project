using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace Final_Project.Controllers
{
    [Authorize(Roles = "Admin,AccountManager")]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var users = await _userManager.Users.Select(user => new UserViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Roles = _userManager.GetRolesAsync(user).Result
                }).ToListAsync();
                return View(users);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> Add()
        {
            try
            {
                var roles = await _roleManager.Roles.Select(r => new RoleViewModel { RoleId = r.Id, RoleName = r.Name }).ToListAsync();

                var viewModel = new AddUserViewModel
                {
                    Roles = roles
                };
                return View(viewModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddUserViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (!model.Roles.Any(r => r.IsSelected))
                {
                    ModelState.AddModelError("Roles", "Please select at least one role");
                    return View(model);
                }


                var user = new ApplicationUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("Roles", error.Description);
                    }

                    return View(model);
                }
                await _userManager.AddToRolesAsync(user, model.Roles.Where(r => r.IsSelected).Select(r => r.RoleName));

            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return NotFound();
                }

                var viewModel = new ProfileFormViewModel
                {
                    Id = userId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email
                };
                return View(viewModel);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProfileFormViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);
                var user = await _userManager.FindByIdAsync(model.Id);

                if (user == null)
                    return NotFound();
                var userWithSameEmail = await _userManager.FindByEmailAsync(model.Email);
                if (userWithSameEmail != null && userWithSameEmail.Id != model.Id)
                {
                    ModelState.AddModelError("Email", "This email is already assigned to another user");
                    return View(model);
                }
                var userWithSameUserName = await _userManager.FindByEmailAsync(model.Email);
                if (userWithSameUserName != null && userWithSameUserName.Id != model.Id)
                {
                    ModelState.AddModelError("UserName", "This username is already assigned to another user");
                    return View(model);
                }
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.UserName;
                user.Email = model.Email;
                await _userManager.UpdateAsync(user);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ManageRoles(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return NotFound();
                }

                var roles = await _roleManager.Roles.ToListAsync();

                var viewModel = new UserRolesViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Roles = roles.Select(role => new RoleViewModel
                    {
                        RoleId = role.Id,
                        RoleName = role.Name,
                        IsSelected = _userManager.IsInRoleAsync(user, role.Name).Result
                    }).ToList()
                };
                return View(viewModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ManageRoles(UserRolesViewModel model)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(model.UserId);

                if (user == null)
                    return NotFound();

                var userRoles = await _userManager.GetRolesAsync(user);

                foreach (var role in model.Roles)
                {
                    if (userRoles.Any(r => r == role.RoleName) && !role.IsSelected)
                        await _userManager.RemoveFromRoleAsync(user, role.RoleName);

                    if (!userRoles.Any(r => r == role.RoleName) && role.IsSelected)
                        await _userManager.AddToRoleAsync(user, role.RoleName);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        public async Task<IActionResult> Delete(string userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);

                // Check if the user exists
                if (user == null)
                    return NotFound();

                // Attempt to delete the user
                var result = await _userManager.DeleteAsync(user);

                // Check if the deletion was successful
                if (!result.Succeeded)
                    throw new Exception("Error deleting user");
            }
            catch (Exception)
            {

                throw;
            }

            // Redirect to the index action (or whichever action lists the users)
            return RedirectToAction("Index");
        }
    }
}
