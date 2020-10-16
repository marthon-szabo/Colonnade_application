using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models.Repositories
{
    public interface IOptionRepository
    {
        public void AddOption(Option option);
        public Option GetOptionById(int? id);
    }
}
