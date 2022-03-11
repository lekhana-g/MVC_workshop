using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Repo
{
    public class ProdRepo : IProdRepo<Product>
    {
        private readonly IProduct<Product> p;
        public ProdRepo()
        {

        }
        public ProdRepo(IProduct<Product> _p)
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
