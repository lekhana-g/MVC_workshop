using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
   public interface IProduct<Product>
    {
        public void AddProduct(Product p);
        public void DeleteProduct(int id);
        public List<Product> GetProducts();
        public Product GetProductById(int id);
    }
}
