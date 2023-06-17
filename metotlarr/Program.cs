using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Product elma = new Product();
            Product urun2 = new Product();
            urun2.Name = "Karpuz";
            urun2.Price = 80;
            urun2.Id = 1;
            urun2.Description = "Diyarbakır karpuzu";


            elma.Name = "Elma";
            elma.Id = 0;
            elma.Description = "Amasya elması";
            elma.Price = 10;

            Product[] products = new Product[] { elma, urun2 };


            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
            }
            Console.WriteLine("------------------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add (urun2);

            Console.ReadLine();
        }
    }
}
