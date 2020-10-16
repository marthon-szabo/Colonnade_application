using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models.Repositories
{
    public class OptionSQLRepository : IOptionRepository
    {
        private readonly ColonnadeAppDbContext context;

        public OptionSQLRepository(ColonnadeAppDbContext context)
        {
            this.context = context;
        }

        public void AddOption(Option option)
        {
            context.Options.Add(option);
            context.SaveChanges();
        }

        public Option GetOptionById(int? id)
        {
            return context.Options.Find(id);
        }
    }
}
