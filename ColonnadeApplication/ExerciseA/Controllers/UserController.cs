﻿using System;
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
        private readonly IUserFactory userFactory;

        public UserController(IUserRepository userRepo, IUserFactory userFactory)
        {
            this.userRepo = userRepo;
            this.userFactory = userFactory;
        }

        public async Task<IActionResult> Create(string email, string name, string address, string phone, string city, string option, int zip)
        {
            var newUser = await userFactory.CreateUserAsync(email, name, address, phone, city, option, zip);
            userRepo.AddUserAsync(newUser);
            return View();
        }
    }
}
