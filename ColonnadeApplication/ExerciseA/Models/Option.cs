using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ExerciseA.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        [DisallowNull]
        public string OptName { get; set; }
        [DisallowNull]
        public int AccidentInsuranceLimit { get; set; }
        [DisallowNull]
        public int Cash { get; set; }
        [DisallowNull]
        public int Luggage { get; set; }
        [DisallowNull]
        public int LuggageLimit { get; set; }
    }
}