using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IServicesUnitOfWork
    {
        IStudentService StudentService { get; set; }
        ICategoryService CategoryService { get; set; }
    }
}
