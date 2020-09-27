using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDapperRepository
    {
        int Execute(string query, object parameters=null);
        IQueryable<T> Query<T>(string query);
        IQueryable<T> QuerySingle<T>(string query, object parameters = null);
        IQueryable<T> QueryWithParameter<T>(string query, object parameters = null);
    }
}
