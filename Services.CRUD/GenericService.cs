using System.Collections.Generic;
using Common.Collection;
using Common.Mapping;
using Common.Paging;
using Persistence.Repository;

namespace Service.CRUD
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private IGenericRepository<T> genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public void Delete(int id)
        {
             genericRepository.Delete(id);
        }
        public IEnumerable<T> GetAll()
        {
            return  genericRepository.GetAll();
        }
        public DataCollection<T> GetPaging(int page, int take)
        {
          var result =  genericRepository.GetAll().GetPagedAsyncAsIENumerable(page, take);

          return result.MapTo<DataCollection<T>>();
        }

        public  T GetById(int id)
        {
            return  genericRepository.GetById(id);
        }

        public  T Insert(T entity)
        {
            return  genericRepository.Insert(entity);
        }

        public  T Update(T entity)
        {
            return  genericRepository.Update(entity);
        }
    }
}
