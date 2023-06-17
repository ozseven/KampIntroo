using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class DortIslem
    {
        public void topla(double sayi1,double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }
        public void bol(double sayi1, double sayi2)
        {
            double sonuc = sayi1 / sayi2;
            Console.WriteLine(sonuc);
        }
        public void cıkar(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            Console.WriteLine(sonuc);
        }
        public void carp(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);
        }
        public void mod(double sayi1, double sayi2)
        {
            double sonuc = sayi1 % sayi2;
            Console.WriteLine(sonuc);
        }
    }
}
