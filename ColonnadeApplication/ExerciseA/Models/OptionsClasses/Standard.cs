using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public sealed class Standard : Options
    {
        public Standard() : base(4, 50000000, 0, 0, 200000000, "Standard")
        {
        }
    }
}
