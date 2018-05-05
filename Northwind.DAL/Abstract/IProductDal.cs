using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Abstract
{
    public interface IProductDAL
    {
        List<Product> GetAll();
        Product Get(int productID);
        void Add(Product product);
        void Delete(int productID);
        void Update(Product product);

    }
}
