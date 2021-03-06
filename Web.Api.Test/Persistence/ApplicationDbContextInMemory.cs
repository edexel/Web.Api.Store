using Microsoft.EntityFrameworkCore;
using Persistance.Database;

namespace Web.Api.Test.Persistence
{
    public class ApplicationDbContextInMemory
    {
        public static ApplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: $"ToysDbTest")
                .Options;
            return new  ApplicationDbContext(options);
        }

    }
}
