using CustomUserManagement.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace CustomUserManagement.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Role.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Role.Editor.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Role.User.ToString()));
        }

        public static async Task SeedAdministratorAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "administrator",
                Email = "administrator@customusermanagement.com",
                EmailConfirmed = true
            };

            var administrators = await userManager.GetUsersInRoleAsync(Role.Administrator.ToString());
            if (!administrators.Any())
            {
                await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                await userManager.AddToRolesAsync(defaultUser, new[] 
                {
                    Role.Administrator.ToString(), 
                    Role.Editor.ToString(), 
                    Role.User.ToString()
                });
            }
        }
    }
}
