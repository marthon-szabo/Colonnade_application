using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public class ColonnadeAppDbContext : DbContext
    {
        public ColonnadeAppDbContext(DbContextOptions<ColonnadeAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Options table
            modelBuilder.Entity<Option>().HasData(
                    new Standard(),
                    new Optimal(),
                    new Medium(),
                    new Extra()
                );
            #endregion
        }
    }
}
