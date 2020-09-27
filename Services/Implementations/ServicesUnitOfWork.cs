using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class ServicesUnitOfWork : IServicesUnitOfWork
    {
        public IStudentService StudentService { get; set; }
        public ICategoryService CategoryService { get; set; }

        public ServicesUnitOfWork(IStudentService studentService,ICategoryService categoryService)
        {
            StudentService = studentService;
            CategoryService = categoryService;
        }
    }
}
