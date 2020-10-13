using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public abstract class Options
    {
        private protected abstract int Id { get; set; }
        private protected abstract string Type { get; set; }
        private protected abstract int AccidentInsuranceLimit { get; set; }
        private protected abstract int Cash { get; set; }
        private protected abstract int Luggage { get; set; }
        private protected abstract string LuggageLimit { get; set; }
    }
}
