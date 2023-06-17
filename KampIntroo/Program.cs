using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 19.2;
            double dolarBugun = 22.5;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar düştü.");
            }else if(dolarBugun>dolarDun){
                Console.WriteLine("Dolar çıktı.");
            }
            else
            {
                Console.WriteLine("Dolar sabit.");
            }

            int[] dolar = new int[100];

            for(int i = 0; i <= dolarDun; i++)
            {
                dolar[i] =i;
            }
            for(int i = 0; i <= 15; i++)
            {
                Console.WriteLine(dolar[i]);
            }
            Console.WriteLine("Program tamamlandı. Devam etmek için bir tuşa basın.");
            Console.ReadLine();
        }
    }
}
