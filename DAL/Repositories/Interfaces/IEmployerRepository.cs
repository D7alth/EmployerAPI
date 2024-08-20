using employer_api.Models.Common;

namespace employer_api.DAL.Repositories.Interfaces;

public interface IEmployerRepository<T>
    where T : BaseModel
{
    public Task<T> Get(int id);
    public Task<T> Delete(int id);
    public Task<T> Update(T entity);
    public Task<IEnumerable<T>> GetAll();
    public Task Create(T entity);
}
