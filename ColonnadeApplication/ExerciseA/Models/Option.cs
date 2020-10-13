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

        [NotNull]
        public int AccidentInsuranceLimit { get; set; }

        [NotNull]
        public int Cash { get; set; }
        [NotNull]
        public int Luggage { get; set; }
        [NotNull]
        public int LuggageLimit { get; set; }
        public ICollection<User> Users { get; set; }
    }
}