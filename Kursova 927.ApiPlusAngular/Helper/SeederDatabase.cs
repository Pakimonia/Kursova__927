using Kursova_927.DataAccess.EF;
using Kursova_927.DataAccess.Entitty;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Kursova_927.ApiPlusAngular.Helper
{
    public class SeederDatabase
    {
        public static void SeedData(IServiceProvider services,
        IWebHostEnvironment env,
        IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var context = scope.ServiceProvider.GetRequiredService<EFContext>();
                SeedUsers(manager, managerRole);
            }
        }
        private static void SeedUsers(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var roleName = "Admin";
            var roleName1 = "Manager";

            if (roleManager.FindByNameAsync(roleName).Result == null  || roleManager.FindByNameAsync(roleName1).Result == null)
            {
                var resultAdminRole = roleManager.CreateAsync(new IdentityRole
                {
                    Name = "Admin"
                }).Result;

                var resultManagerRole = roleManager.CreateAsync(new IdentityRole
                {
                    Name = "Manager"
                }).Result;

                var resultUserRole = roleManager.CreateAsync(new IdentityRole
                {
                    Name = "User"
                }).Result;
            }

            string email = "admin@gmail.com";
            var admin = new User
            {
                Email = email,
                UserName = email,
                Address = "Rivne",
                Age = 17,
                FullName = "Mykola Zaiets"
            };
            string email1 = "manager@gmail.com";
            var manager = new User
            {
                Email = email1,
                UserName = email1,
                Address = "Rivne",
                Age = 17,
                FullName = "Mykola Zaiets"
            };
            //var andrii = new User
            //{
            //    Email = "zaietsmikola.21@gmail.com",
            //    UserName = "zaietsmikola.21@gmail.com"
            //};

            //var resultAdmin = userManager.CreateAsync(admin, "Qwerty1-").Result;
            //resultAdmin = userManager.AddToRoleAsync(admin, "Manager").Result;

            var resultManager = userManager.CreateAsync(manager, "Qwerty1-").Result;
            resultManager = userManager.AddToRoleAsync(manager, "Manager").Result;

            //var resultAndrii = userManager.CreateAsync(andrii, "Qwerty1-").Result;
            //resultAndrii = userManager.AddToRoleAsync(andrii, "User").Result;
        }
    }
}
