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

        public async void AddUser(User newUser)
        {
            context.Users.Add(newUser);
            await context.SaveChangesAsync();
        }

        public async void DeletUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
