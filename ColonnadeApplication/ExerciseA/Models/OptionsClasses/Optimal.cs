using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public sealed class Optimal : Options
    {
        public Optimal() 
            : base (1, 200000000, 100000, 200000, 200000000, "Optimal")
        {
        }        
    }
}
