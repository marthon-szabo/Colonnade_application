using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public class UsersOption
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public int UserId { get; set; }
        [NotNull]
        public int OptionId { get; set; }
        public User User { get; set; }
        public Option Option { get; set; }

    }
}
