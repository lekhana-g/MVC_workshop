using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Product:IProduct<Product>
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }


        public static List<Product> prods = new List<Product>();
        public Product()
        {

        }

        public Product(int pid,string pname,int qty,int price)
        {
            Pid = pid;
            Pname = pname;
            Qty = qty;
            Price = price;
        }

        public List<Product> GetProducts()
        {
            return prods;
        }

        public void AddProduct(Product p)
        {
            prods.Add(p);

        }

        public void DeleteProduct(int id)
        {
            Product P = GetProductById(id);
            prods.Remove(P);
        }

        public Product GetProductById(int id)
        {
            prods = GetProducts();
            Product p = prods.Where(p=>p.Pid==id).FirstOrDefault();
            return p;
        }

       
    }
}
