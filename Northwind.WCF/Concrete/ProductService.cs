using Northwind.Bussines.Concrete;
using Northwind.DAL.Concrete;
using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.WCF.Concrete
{
    public class ProductService : IProductService
    {
        ProductManager _productManeger = new ProductManager(new ProductDAL());
        public void Add(Product product)
        {
            _productManeger.Add(product);
        }

        public void Delete(int productID)
        {
            _productManeger.Delete(productID);
        }

        public Product Get(int productID)
        {
            return Get(productID);
        }

        public List<Product> GetAll()
        {
            return _productManeger.GetAll();
         }

        public void Update(Product product)
        {
            _productManeger.Update(product);
        }
    }
}