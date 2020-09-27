using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Repository.Implementations
{
    public class DapperRepository : IDapperRepository
    {
        public int Execute(string query, object parameters = null)
        {
            using (var connection = DbRepository.SqlConnection())
            {
            return  connection.Execute(query, commandType: CommandType.StoredProcedure);
            }
        }

        public IQueryable<T> Query<T>(string query)
        {
            using (var connection=DbRepository.SqlConnection())
            {
                return connection.Query<T>(query, commandType:CommandType.StoredProcedure).AsQueryable();
            }
        }

        public IQueryable<T> QuerySingle<T>(string query, object parameters = null)
        {
            using (var connection = DbRepository.SqlConnection())
            {
                return (IQueryable<T>)connection.QueryFirstOrDefault<T>(query, parameters, commandType: CommandType.StoredProcedure);
            }

       }

        public IQueryable<T> QueryWithParameter<T>(string query, object parameters = null)
        {
            using (var connection = DbRepository.SqlConnection())
            {
                return connection.Query<T>(query, parameters, commandType: CommandType.StoredProcedure).AsQueryable();
            }
        }
    }
}
