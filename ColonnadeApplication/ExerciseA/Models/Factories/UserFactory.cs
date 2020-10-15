using ExerciseA.Models.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
        // TODO: Delete async
        public async Task<User> CreateUserAsync(string email, string name, string address, string phone, string city, string option, int zip)
        {

            int? userOption = optionsFactory.CreateOption(option);

            if (userOption == null)
            {
                throw new ArgumentNullException("There is no argument for Option!");
            }

            User newUser = new User
            {
                Address = address,
                City = city,
                Email = email,
                Zip = zip,
                Name = name,
                Phone = phone,
                OptionId = userOption
            };

            return newUser;
        }
    }
}
