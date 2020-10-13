using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public int Zip { get; set; }

        [NotNull]
        public string City { get; set; }

        [NotNull]
        public string Address { get; set; }

        [NotNull]
        [Phone]
        public int Phone { get; set; }

        [NotNull]
        [EmailAddress]
        public string Email { get; set; }

        [NotNull]
        public Option Option { get; set; }
    }
}
