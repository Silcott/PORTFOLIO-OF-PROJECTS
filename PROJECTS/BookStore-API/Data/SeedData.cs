using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Data
{
    public static class SeedData
    {
        public async static Task Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }
        private async static Task SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@bookstore.com") == null ||
                userManager.FindByEmailAsync("admin@bookstore.com") !=
                userManager.FindByEmailAsync("admin@bookstore.com"))
            {
                var user = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@bookstore.com"
                };
                var result = await userManager.CreateAsync(user, "P@ssword1");
                if (result.Succeeded)
                {
                   await userManager.AddToRoleAsync(user, "Administrator");
                }
            }
            //For loop to create 2 customers
            int amountOfCoustomers = 3;
            for (int i = 1; i < amountOfCoustomers; )
            {
                if (await userManager.FindByEmailAsync($"customer{i}@gmail.com") == null ||
                    userManager.FindByEmailAsync($"customer{i}@gmail.com") !=
                    userManager.FindByEmailAsync($"customer{i}@gmail.com"))
                {
                    var user = new IdentityUser
                    {
                        UserName = $"customer{i}",
                        Email = $"customer{i}@gmail.com"
                    };
                    var result = await userManager.CreateAsync(user, "P@ssword1");
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "Customer");
                    }
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }

        private async static Task SeedRoles(RoleManager<IdentityRole> roleManger)
        {
            if (!roleManger.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                await roleManger.CreateAsync(role);
            }
            if (!roleManger.RoleExistsAsync("Customer").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Customer"
                };
                await roleManger.CreateAsync(role);
            }
        }
    }
}
