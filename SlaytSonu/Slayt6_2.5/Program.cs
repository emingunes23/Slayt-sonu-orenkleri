using System;
enum GUNLER : byte
{
    PAZARTESİ,
    SALI,
    CARSAMBA,
    PERSEMBE,
    CUMA,
    CUMARTESİ,
    PAZAR
}

class Numaralandirma
{
    public static void Main()
    {
        string[] sabitler = Enum.GetNames(typeof(GUNLER));
        foreach ( string s in sabitler )
            Console.WriteLine(s);
        Console.ReadLine();
    }
}