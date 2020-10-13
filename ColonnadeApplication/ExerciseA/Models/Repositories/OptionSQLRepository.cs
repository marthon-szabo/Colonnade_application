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
            await context.Options.AddAsync(option);
        }

        public Task<Option> GetOptionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
