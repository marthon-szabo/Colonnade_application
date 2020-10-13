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

        public async void AddOptionAsync(Option option)
        {
            context.Options.AddAsync(option);
            await context.SaveChangesAsync();
        }

        public async Task<Option> GetOptionByIdAsync(int id)
        {
            return await context.Options.FindAsync(id);
        }
    }
}
