using CustomUserManagement.Models;
using CustomUserManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomUserManagement.Controllers
{
    public class UserRolesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRolesController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new List<UserRolesViewModel>();
            foreach (var user in _userManager.Users)
            {
                viewModel.Add(new UserRolesViewModel
                {
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserId = user.Id,
                    Username = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user)
                });
            }

            return View(viewModel);
        }
    }
}
