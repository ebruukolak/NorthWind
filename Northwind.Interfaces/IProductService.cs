using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interfaces
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();
        [OperationContract]
        Product Get(int productID);
        [OperationContract]
        void Add(Product product);
        [OperationContract]
        void Delete(int productID);
        [OperationContract]
        void Update(Product product);
    }
}
