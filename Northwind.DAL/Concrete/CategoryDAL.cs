using Northwind.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;

namespace Northwind.DAL.Concrete
{
    public class CategoryDAL : ICategoryDAL
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
