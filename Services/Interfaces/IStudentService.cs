using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface IStudentService
    {
        bool Add(Student student);
        bool Update(Student student);
        bool Delete(int? studentId);

        IQueryable<Student> GetAll();
        IQueryable<Student> GetSingleRecord(int? studentId);


    }
}
