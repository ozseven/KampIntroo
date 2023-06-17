using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarr
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi: "+product.Name);
        }
    }
}
