using employer_api.DAL.DataContext;
using employer_api.DAL.Repositories.Interfaces;
using employer_api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace employer_api.DAL.Repositories;

public class EmployerRepository(ApplicationDbContext context) : IEmployerRepository<Employer>
{
    public async Task<Employer> Get(int id)
    {
        try
        {
            return await context.Employers.FindAsync(id) ?? null!;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task Remove(int id)
    {
        try
        {
            var employer = context.Employers.FirstOrDefault(em => em.Id == id) ?? null!;
            context.Employers.Remove(employer);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task Update(Employer entity)
    {
        try
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<IEnumerable<Employer>> GetAll()
    {
        try
        {
            return await context.Employers.ToListAsync();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task Add(Employer entity)
    {
        try
        {
            context.Add(entity);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
