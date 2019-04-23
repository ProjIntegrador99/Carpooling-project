using Carpooling.Data;
using Carpooling.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace IdentityCore.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<Usuario> userManager,
                              RoleManager<RolUsuario> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new RolUsuario(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new RolUsuario(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("aa@aa.aa") == null)
            {
                var user = new Usuario
                {
                    Nombre = "aa@aa.aa",
                    Nick = "Messi",
                    Email = "aa@aa.aa",
                    Apellido = "Aldridge",
                    Direccion = "Fake St",
                    Ciudad = "Vancouver",
                    Pais = "Canada",
                    PhoneNumber = "6902341234"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("bb@bb.bb") == null)
            {
                var user = new Usuario
                {
                    Nombre = "bb@bb.bb",
                    Email = "bb@bb.bb",
                    Nick = "Ronaldo",
                    Apellido = "Barker",
                    Direccion = "Vermont St",
                    Ciudad = "Surrey",
                    Pais = "Canada",
                    PhoneNumber = "7788951456"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId2 = user.Id;
            }
        }
    }
}