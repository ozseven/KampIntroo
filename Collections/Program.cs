using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Ahmet", "Emirhan", "Hira" };

            List<string> isimler2 = new List<string>();
            isimler2.Add("Ahmet");
            Console.WriteLine(isimler2[0]);
            

            Console.ReadLine();
        }
    }
}
