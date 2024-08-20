using employer_api.Models;
using employer_api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace employer_api.DAL.DataContext;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<Employer> Employers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employer>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        });
    }
}
