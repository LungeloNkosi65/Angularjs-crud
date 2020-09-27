using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class DbRepository
    {
        private static readonly string _connectionString= "Server=(LocalDb)\\LocalDb.;Database=CrudDapper;Trusted_Connection=True;";
        
        public static SqlConnection SqlConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }
    }
}
