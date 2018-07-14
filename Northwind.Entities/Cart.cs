using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{
    public class Cart
    {
        List<CartLine> _lines = new List<CartLine>();
        public void AddToCart(Product product,int quantity)
        {
            CartLine cartLine = _lines.FirstOrDefault(x => x.Product.ProductID == product.ProductID);
            if (cartLine == null)
            {
                _lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                cartLine.Quantity += quantity;
            }
        }
        public void RemoveFromCart(Product product)
        {
            _lines.RemoveAll(x => x.Product.ProductID == product.ProductID);
        }
        public decimal Total
        {
            get { return _lines.Sum(x => x.Product.UnitPrice * x.Quantity); }
        }
        public void Clear()
        {
            _lines.Clear();
        }
        public List<CartLine> Lines
        {
            get { return _lines; }
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
