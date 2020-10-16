using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public interface IUserRepository
    {
        public void AddUser(User newUser);
        public User GetUserById(int? id);
    }
}
