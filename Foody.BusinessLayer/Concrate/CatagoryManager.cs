using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrate
{
    public class CatagoryManager : ICategoryService
    {
        private readonly ICategoryService _categoryService;
        public CatagoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public void TDelete(int id)
        {
            _categoryService.TDelete(id);
        }

        public List<Category> TGetAll()
        {
           return _categoryService.TGetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryService.TGetById(id);
        }

        public void TInsert(Category entity)
        {
            _categoryService.TInsert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryService.TUpdate(entity);
        }
    }
}
