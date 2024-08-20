using employer_api.DAL.DataContext;
using Microsoft.EntityFrameworkCore;

namespace employer_api.DAL.Repositories;

public class Employer(ApplicationDbContext context) : IEmployer<Models.Employer>
{
    public async Task<Models.Employer> Get(int id)
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

    public Task<Models.Employer> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Models.Employer> Update(Models.Employer entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Models.Employer>> GetAll()
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
}