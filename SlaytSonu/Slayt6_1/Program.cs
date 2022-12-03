using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slayt6_1
{
    class Zaman
    {
        public int Saat; public int Dakika; public int Saniye;
        public Zaman(int saat, int dakika, int saniye)
        {
            Dakika = dakika + saniye / 60;
            Saniye = saniye % 60;
            Saat = saat + Dakika / 60;
            Dakika = Dakika % 60;
        }
        public static Zaman operator +(Zaman a, Zaman b)
        {
            int ToplamSaniye = a.Saniye + b.Saniye;
            int ToplamDakika = a.Dakika + b.Dakika;
            int ToplamSaat = a.Saat + b.Saat;
            return new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);
        }
    }
    class AnaProgram
    {
        static void Main()
        {
            Zaman zaman1 = new Zaman(5, 59, 60);
            Zaman zaman2 = new Zaman(1, 0, 120);
            Zaman zaman3 = zaman1 + zaman2;

            Console.WriteLine("{0}.{1}.{2}", zaman3.Saat, zaman3.Dakika,
            zaman3.Saniye);
            Console.ReadLine();
        }
    }


}
