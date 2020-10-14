using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseA.Models;
using ExerciseA.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseA.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepo;
        private readonly IOptionRepository optionRepo;
        private readonly IUserFactory userFactory;

        public UserController(IUserRepository userRepo, IOptionRepository optionRepo, IUserFactory userFactory)
        {
            this.userRepo = userRepo;
            this.optionRepo = optionRepo;
            this.userFactory = userFactory;
        }

        public async Task<IActionResult> Create(string email, string name, string address, string phone, string city, string option, int zip)
        {
            User newUser = userFactory.CreateUserAsync(email, name, address, phone, city, option, zip).Result;
            userRepo.AddUserAsync(newUser);
            Response.Redirect($"/User/Actual?id={newUser.Id}");

            return View();
        }

        public IActionResult Actual(string id)
        {
            User user = userRepo.GetUserByIdAsync(Convert.ToInt32(id)).Result;
            int? optionId = user.OptionId;
            Option option = optionRepo.GetOptionByIdAsync(optionId).Result;
            ViewData["OptName"] = option.OptName;
            
            return View(user);
        }
    }
}
