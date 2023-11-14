using Microsoft.AspNetCore.Identity;


namespace CarDealershipApp.Models
{
    public class ConfigureIdentity
    {
        public static async Task CreateAdminAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            string username = "Admin";        // username for admin
            string password = "Password10";   // password for admin
            string roleName = "Admin";        // role assigned to admin

            //add role if it does not exist
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            //add user if does not exist
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }

        }
    }
}
