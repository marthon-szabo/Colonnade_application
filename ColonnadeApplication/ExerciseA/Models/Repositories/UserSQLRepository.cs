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

        public async void AddUserAsync(User newUser)
        {
            await context.Users.AddAsync(newUser);
            await context.SaveChangesAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await context.Users.FindAsync(id);
        }
    }
}
