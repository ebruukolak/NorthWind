using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;
using Northwind.DAL.Abstract;

namespace Northwind.Bussines.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDal;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
