using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public class UserFactory : IUserFactory
    {
        public async Task<User> CreateUserAsync(FormCollection form)
        {
            User newUser = new User
            {
                Address = form["Address"],
                City = form["City"],
                Email = form["Email"],
                Zip = Convert.ToInt32(form["Zip"]),
                Name = form["Name"],
                Phone = Convert.ToInt32(form["Phone"]),

            };

            return newUser;
        }
    }
}
