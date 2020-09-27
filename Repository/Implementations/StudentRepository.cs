using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
   public class StudentRepository : IGenericRepository<Student>
    {
        private readonly IDapperRepository _dapperRepository;

        public StudentRepository(IDapperRepository dapperRepository)
        {
            _dapperRepository = dapperRepository;
        }
        public bool Add(Student entity)
        {
            string sqlcommand = "AddStudent";
            var parameters = new
            {
                entity.StudentName,
                entity.Surname,
                entity.StudentNumber,
            };
            var results = _dapperRepository.Execute(sqlcommand, parameters);
            return results == 0;
        }

        public bool Delete(object id)
        {
            string sqlcommand = "DeleteStudecnt";
            var parameter = new { id };
            var results = _dapperRepository.Execute(sqlcommand, parameter);
            return results == 0;
        }

        public IQueryable<Student> GetAll()
        {
            string sqlcommand = "SelectStudents";
            return _dapperRepository.Query<Student>(sqlcommand);
        }

        public IQueryable<Student> GetSingle(object id)
        {
            string sqlcommand = "GetSingleStudent";
            var parameters = new { id };
            return _dapperRepository.QuerySingle<Student>(sqlcommand, parameters);
        }

        public bool Update(Student entity)
        {
            string sqlcommandt = "UpdateStudent";
            var parameters = new
            {
                entity.StudentId,
                entity.StudentName,
                entity.Surname,
                entity.StudentNumber
            };
            var result = _dapperRepository.Execute(sqlcommandt, parameters);
            return result == 0;
        }
    }
}
