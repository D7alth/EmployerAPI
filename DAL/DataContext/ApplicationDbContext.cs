using employer_api.Models;
using Microsoft.EntityFrameworkCore;

namespace employer_api.DAL.DataContext;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Employer> Employers { get; set; }
    
}
