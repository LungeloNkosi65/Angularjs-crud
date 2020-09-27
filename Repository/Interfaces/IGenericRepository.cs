using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
   public interface IGenericRepository<T> where T: class
    {
        bool Add (T entity);
        bool Update(T entity);
        bool Delete(object id);
        IQueryable<T> GetAll();
        IQueryable<T> GetSingle(object id);
        
    }
}
