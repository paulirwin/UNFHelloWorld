using System.Data.Entity;

namespace UNFHelloWorld.Models
{
    public class HelloDbContext : DbContext
    {
        public HelloDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<HelloData> HelloData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HelloData>().ToTable("HelloData");
        }
    }

    public class HelloData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}