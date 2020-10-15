using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models.Repositories
{
    public class UserSQLRepository : IUserRepository
    {
        private readonly ColonnadeAppDbContext context;

        public UserSQLRepository(ColonnadeAppDbContext context)
        {
            this.context = context;
        }

        public void AddUser(User newUser)
        {
            context.Users.Add(newUser);
            context.SaveChanges();
        }

        public User GetUserById(int? id)
        {
            return context.Users.Find(id);
        }
    }
}
