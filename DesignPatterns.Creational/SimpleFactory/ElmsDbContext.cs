using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class ElmsDbContext : DbContext

    {
        public ElmsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}