using System;
class Yapilar
{
    struct Ogrenci
    {
        public int Numara;
        public string Ad;
        public string Soyad;

    }
    public static void Main()
    {
        Ogrenci ogr1 = new Ogrenci();
        ogr1.Numara = 123;
        ogr1.Ad = "Ali";
        ogr1.Soyad = "Türk";
        Ogrenci ogr2 = ogr1;
        ogr2.Numara = 456;
        Console.WriteLine("{0} {1} {2}", ogr1.Numara, ogr1.Ad, ogr1.Soyad);
        Console.WriteLine("{0} {1} {2}", ogr2.Numara, ogr2.Ad, ogr2.Soyad);
        Console.ReadLine();
    }
}