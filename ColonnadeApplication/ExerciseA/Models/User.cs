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

        [DisallowNull]
        public string Name { get; set; }

        [DisallowNull]
        public int Zip { get; set; }

        [DisallowNull]
        public string City { get; set; }

        [DisallowNull]
        public string Address { get; set; }

        [DisallowNull]
        [Phone]
        public string Phone { get; set; }

        [DisallowNull]
        [EmailAddress]
        public string Email { get; set; }

        // TODO: Not nullable!
        [DisallowNull]
        public int? OptionId { get; set; }

    }
}
