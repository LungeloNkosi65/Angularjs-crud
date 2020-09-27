using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class CategoryRepository : IGenericRepository<Category>
    {
        private readonly IDapperRepository _dapperRepository;
        public CategoryRepository(IDapperRepository dapperRepository)
        {
            _dapperRepository = dapperRepository;
        }
        public bool Add(Category entity)
        {
           using(var connection = DbRepository.SqlConnection())
            {
                var sqlCommand = "AddCategory";
                var parameter = new { entity.CategoryName };
                var results = _dapperRepository.Execute(sqlCommand, parameter);
                return results == 0;
            }
        }

        public bool Delete(object id)
        {
            using (var connection = DbRepository.SqlConnection())
            {
                string sqlCommand = "DeleteCategory";
                var parameter = new { id };
                var results = _dapperRepository.Execute(sqlCommand, parameter);
                return results == 0;
            }
           
        }

        public IQueryable<Category> GetAll()
        {
            using (var connection = DbRepository.SqlConnection())
            {
                string sqlcommand = "GetCategory";
                return _dapperRepository.Query<Category>(sqlcommand);
            }
        }

        public IQueryable<Category> GetSingle(object id)
        {
            using (var connection = DbRepository.SqlConnection())
            {
                string sqlcommand = "GetSingleCategory";
                var parameter = new { id };
                return _dapperRepository.QuerySingle<Category>(sqlcommand, parameter);

            }
        }

        public bool Update(Category entity)
        {
            using (var connection = DbRepository.SqlConnection())
            {
                string sqlCommand = "UpdateCategory";
                var parameters = new { entity.CategoryId, entity.CategoryName };
                var results = _dapperRepository.Execute(sqlCommand, parameters);
                return results == 0;
            }
            
        }
    }
}
