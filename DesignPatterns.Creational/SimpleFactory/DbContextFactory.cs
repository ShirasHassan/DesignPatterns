using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class DbContextFactory : IDbContextFactory
    {
        public ElmsDbContext GetElmsDbContext(string environment)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ElmsDbContext>();
            optionsBuilder.UseSqlServer(@"Data Source=193.11.10.01\\SQL;Initial Catalog=Elms;Integrated Security=True");
            if (environment.ToLower() == "dev")
            {
                optionsBuilder.UseSqlServer(@"Data Source=(local)\\SQL;Initial Catalog=Elms;Integrated Security=True");
            }
            return new ElmsDbContext(optionsBuilder.Options);
        }
    }

    public interface IDbContextFactory
    {
      ElmsDbContext  GetElmsDbContext(string environment);
    }
}