using System;
class Temsilciler
{
    public delegate void KomutMetodu();
    public struct KomutYapisi
    {
        public KomutMetodu KomutMetot;
        public string Komut;
    }
    public static void Komut1()
    {
        Console.WriteLine("Komut1 çalıştı");
    }
    public static void Komut2()
    {
        Console.WriteLine("Komut2 çalıştı");
    }
    public static void Komut3()
    {
        Console.WriteLine("komut 3 çalıştı");
    }
    public static void Komut4()
    {
        Console.WriteLine("Komut4 çalıştı");
    }
    static void Main()
    {
        KomutYapisi[] komutlar = new KomutYapisi[4];
        komutlar[0].Komut = "Komut1";
        komutlar[0].KomutMetot = new KomutMetodu(Komut1);

        komutlar[1].Komut = "komut2";
        komutlar[1].KomutMetot = new
        KomutMetodu(Komut2);
        komutlar[2].Komut = "komut3";
        komutlar[2].KomutMetot = new
        KomutMetodu(Komut3);
        komutlar[3].Komut = "komut4";
        komutlar[3].KomutMetot = new
         KomutMetodu(Komut4);
        Console.Write("Komut girin: "); string
         GirilenKomut = Console.ReadLine();

        for (int i = 0; i < komutlar.Length; i++)
            if (GirilenKomut == komutlar[i].Komut)
                komutlar[i].KomutMetot();
    }
}


