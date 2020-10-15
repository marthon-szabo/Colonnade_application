using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models.Factories
{
    public class OptionFactory : IOptionFactory
    {
        private readonly ColonnadeAppDbContext context;

        public OptionFactory(ColonnadeAppDbContext context)
        {
            this.context = context;
        }

        public int CreateOption(string type)
        {
            switch (type)
            {
                case "Optimal":
                    return 1;
                case "Extra":
                    return 2;
                case "Medium":
                    return 3;
                case "Standard":
                    return 4;
                default:
                    return 4;
            }
        }
    }
}
