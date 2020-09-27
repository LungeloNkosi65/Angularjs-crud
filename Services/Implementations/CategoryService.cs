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
    public class CategoryService : ICategoryService
    {
        private IGenericRepository<Category> _genericRepository;

        public CategoryService(IGenericRepository<Category> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public bool Add(Category category)
        {
            return _genericRepository.Add(category);
        }

        public bool Delete(int? categoryId)
        {
            return _genericRepository.Delete(categoryId);
        }

        public IQueryable<Category> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public IQueryable<Category> GetSingle(int? categoryId)
        {
            return _genericRepository.GetSingle(categoryId);
        }

        public bool Update(Category category)
        {
            return _genericRepository.Update(category);
        }
    }
}
