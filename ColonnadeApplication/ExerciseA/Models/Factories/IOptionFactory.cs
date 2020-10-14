using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models.Factories
{
    public interface IOptionFactory
    {
        public Option CreateOption(String type);
    }
}
