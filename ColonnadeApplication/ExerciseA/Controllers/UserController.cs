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

        public UserController(IUserRepository userRepo)
        {
            this.userRepo = userRepo;
        }

        public async Task<IActionResult> Create(FormCollection form)
        {
            
            return View();
        }
    }
}
