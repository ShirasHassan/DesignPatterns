namespace DesignPatterns.Creational.SimpleFactory
{
    public class Program
    {
        public static void Run()
        {
            var dbContext = new DbContextFactory().GetElmsDbContext("dev");
        }
    }
}