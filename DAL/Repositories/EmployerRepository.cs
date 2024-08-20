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

    public Task<Employer> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Employer> Update(Employer entity)
    {
        throw new NotImplementedException();
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

    public async Task Create(Employer entity)
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
