using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Database.Configuration;

namespace Persistance.Database
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PlayThing> PlayThing { get; set; }
        //public DbSet<Salary> salary { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ModelConfig(builder);
        }
       


        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new PlayThingConfiguration(modelBuilder.Entity<PlayThing>());
        }
    }
}
