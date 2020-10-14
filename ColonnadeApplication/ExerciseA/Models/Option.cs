using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ExerciseA.Models
{
    public class Option
    {
        private ICollection<User> _users = new List<User>();
        [Key]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }
        [NotNull]
        public int AccidentInsuranceLimit { get; set; }

        [NotNull]
        public int Cash { get; set; }
        [NotNull]
        public int Luggage { get; set; }
        [NotNull]
        public int LuggageLimit { get; set; }
        public ICollection<User> Users { get => _users; }
    }
}