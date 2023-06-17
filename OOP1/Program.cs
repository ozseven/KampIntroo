using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Phone";
            product1.categoryId = 0;
            product1.UnitInStock = 100;
            product1.Price = 5000;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



            Console.Read();
        }
    }
}
