using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public interface IUserFactory
    {
        public Task<User> CreateUserAsync(FormCollection form);
    }
}
