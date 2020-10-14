using ExerciseA.Models.Factories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public class UserFactory : IUserFactory
    {
        private readonly IOptionFactory optionsFactory;
        private readonly ColonnadeAppDbContext context;

        public UserFactory(IOptionFactory optionsFactory, ColonnadeAppDbContext context)
        {
            this.optionsFactory = optionsFactory;
            this.context = context;
        }

        public async Task<User> CreateUserAsync(FormCollection form)
        {
            Option option = optionsFactory.CreateOption(form["Option"]);
            User newUser = new User
            {
                Address = form["Address"],
                City = form["City"],
                Email = form["Email"],
                Zip = Convert.ToInt32(form["Zip"]),
                Name = form["Name"],
                Phone = Convert.ToInt32(form["Phone"]),
                Option = option
            };

            option.Users.Add(newUser);
            context.SaveChanges();
            
            return newUser;
        }
    }
}
