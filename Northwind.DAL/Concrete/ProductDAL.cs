using Northwind.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;

namespace Northwind.DAL.Concrete
{
    public class ProductDAL : IProductDAL
    {
        NorthwindContext _context = new NorthwindContext();
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productID)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(x => x.ProductID == productID));
        }

        public Product Get(int productID)
        {
            return _context.Products.FirstOrDefault(x => x.ProductID == productID);
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _context.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            _context.SaveChanges();

        }
    }
}
