using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public interface IUserRepository
    {
        public void AddUserAsync(User newUser);
        public Task<User> GetUserByIdAsync(int? id);
    }
}
