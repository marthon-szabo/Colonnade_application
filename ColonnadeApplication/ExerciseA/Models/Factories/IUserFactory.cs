using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public interface IUserFactory
    {
        public User CreateUser(string email, string name, string address, string phone, string city, string option, int zip);
    }
}
