using System;
enum GUNLER : byte
{
    PAZARTESI,
    SALI,
    CARSAMABA,
    PERSEMBE,
    CUMA,
    CUMARTESİ,
    PAZAR
}
 class Numaralandirma
{
    public static void Main()
    {
        Console.WriteLine((int)GUNLER.PAZARTESI);
        Console.WriteLine((int)GUNLER.PAZAR);
        Console.ReadLine();
    }
}