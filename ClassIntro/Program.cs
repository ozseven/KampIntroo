using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.egitmen = "Engin demirog";
            kurs1.izlenmesayisi = 1021;
            kurs1.kursAdi = "C# egtimi";
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmesayisi { get; set; }
    }
}
