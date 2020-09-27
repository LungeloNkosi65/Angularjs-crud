using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        bool Add(Category category);
        bool Delete(int? categoryId);
        bool Update(Category category);
        IQueryable<Category> GetAll();
        IQueryable<Category> GetSingle(int? categoryId);
    }
}
