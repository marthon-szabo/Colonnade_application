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

        public void AddOptionAsync(Options option)
        {
            throw new NotImplementedException();
        }

        public Task<Options> GetOptionByIdAsync(Options option)
        {
            throw new NotImplementedException();
        }
    }
}
