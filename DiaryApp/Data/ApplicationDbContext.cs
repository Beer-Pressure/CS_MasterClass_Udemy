using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id = 1, Title = "Went to the gym", Content = "Did weak workout with injury", Created = DateTime.MinValue},
                new DiaryEntry { Id = 2, Title = "Went to the doctor", Content = "Did physio", Created = DateTime.MinValue},
                new DiaryEntry { Id = 3, Title = "Went to sleep", Content = "Dreamed about being rich", Created = DateTime.MinValue },
                new DiaryEntry { Id = 4, Title = "Woke up", Content = "Wore brace", Created = DateTime.MinValue }
                );
        }
    }
}
