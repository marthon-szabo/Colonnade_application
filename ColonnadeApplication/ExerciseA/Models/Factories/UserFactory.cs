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

        public async Task<User> CreateUserAsync(string email, string name, string address, string phone, string city, string option, int zip)
        {
            Option userOption = optionsFactory.CreateOption(option);
            User newUser = new User
            {
                Address = address,
                City = city,
                Email = email,
                Zip = zip,
                Name = name,
                Phone = phone,
                Option = userOption
            };

            userOption.Users.Add(newUser);
            context.SaveChanges();
            
            return newUser;
        }
    }
}
