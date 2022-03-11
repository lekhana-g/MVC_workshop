using ProductAPI.Models;
using ProductAPI.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Service
{
    public class ProdService : IProdser<Product>
    {
        private readonly IProdRepo<Product> p;
        public ProdService()
        {

        }
        
        public ProdService(IProdRepo<Product> _p)
        {
            p = _p;
        }
        public void AddProduct(Product p)
        {
            p.AddProduct(p);   
        }

        public void DeleteProduct(int id)
        {
            p.DeleteProduct(id);
        }

        public Product GetProductById(int id)
        {
            return p.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
           return p.GetProducts();
        }
    }
}
