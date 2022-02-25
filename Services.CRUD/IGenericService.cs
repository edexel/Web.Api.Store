using Common.Collection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.CRUD
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAll();
        DataCollection<T> GetPaging(int page, int take);
        T GetById(int id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
