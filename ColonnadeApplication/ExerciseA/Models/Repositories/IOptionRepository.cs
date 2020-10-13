using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models.Repositories
{
    public interface IOptionRepository
    {
        public void AddOptionAsync(Options option);
        public Task<Options> GetOptionByIdAsync(Options option);
    }
}
