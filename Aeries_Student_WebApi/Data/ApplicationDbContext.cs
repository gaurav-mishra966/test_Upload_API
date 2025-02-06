using Aeries_Student_WebApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Aeries_Student_WebApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        //Creating constructor of DB contect class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }       

        public DbSet<Medical> MedicalData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medical>()
                .HasNoKey();  // Mark the entity as keyless
        }

    }
}
