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

        public Option CreateOption(string type)
        {
            switch (type)
            {
                case "Optimal":
                    return context.Options.Find("Optimal");
                case "Extra":
                    return context.Options.Find("Extra");
                case "Medium":
                    return context.Options.Find("Medium");
                case "Standard":
                    return context.Options.Find("Standard");
                default:
                    return null;
            }
        }
    }
}
