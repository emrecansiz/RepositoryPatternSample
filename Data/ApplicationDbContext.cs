
using Microsoft.EntityFrameworkCore;

namespace RepositoryPatternSample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>()
                .HasData(
                    new People{
                        Id=1,
                        Name="test1",
                        SurName="test2"
                    },
                    new People
                    {
                        Id=2,
                        Name="test3",
                        SurName="test4"
                    }
                    );
        }
        DbSet<People> Peoples { get; set; }
    }
}