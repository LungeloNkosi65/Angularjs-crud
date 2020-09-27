using Models;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Student> _genericRepository;

        public StudentService(IGenericRepository<Student> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public bool Add(Student student)
        {
            return _genericRepository.Add(student);
        }

        public bool Delete(int? studentId)
        {
            return _genericRepository.Delete(studentId);
        }

        public IQueryable<Student> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public IQueryable<Student> GetSingleRecord(int? studentId)
        {
            return _genericRepository.GetSingle(studentId);
        }

        public bool Update(Student student)
        {
            return _genericRepository.Update(student);
        }
    }
}
