using Data.Model;

namespace Data.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        string Create(T entity);
        string Delete(int id);
        string Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}