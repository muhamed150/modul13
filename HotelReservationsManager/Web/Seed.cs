using Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web
{
    public class Seed
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public Seed()
        {

        }
        public Seed(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task SeederAsync()
        {
            var user = new User { Id = Guid.NewGuid().ToString(), UserName = "adminAtanas@abv.bg", Email = "adminAtanas@abv.bg", FirstName = "Atanas", MiddleName = "Ivanov", LastName = "Mihaylov", EGN = "7306078725", HireDate = new DateTime(2002, 11, 25), IsActive = true, isAdmin = true, PhoneNumber = "0877923606" };
            var result = await _userManager.CreateAsync(user, "12345");
            if (result.Succeeded)
            {
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }
            }
        }
    }
}
