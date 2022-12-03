using System;
class Program
{
    static void Main()
    {
        int yil, ay, gun;
        Console.Write("Doğum Yılınız:");
        yil = Convert.ToInt32(Console.ReadLine());
        Console.Write("Doğum Ayınız:");
        ay = Convert.ToInt32(Console.ReadLine());
        Console.Write("Doğum Gününüz:");
        gun = Convert.ToInt32(Console.ReadLine());
        DateTime bugun = DateTime.Today;
        DateTime dogumGunu = new DateTime(yil, ay, gun);
        TimeSpan fark = bugun - dogumGunu;
        Console.WriteLine("Doğduğunuz Gün: { 0}", dogumGunu.DayOfWeek);
        Console.WriteLine("Gün Sayısı: {0}", fark.Days);
        Console.WriteLine();
        Console.Write("Gün Sayısı:" );
        gun = Convert.ToInt32(Console.ReadLine());
        TimeSpan GunSayisi = new TimeSpan(gun, 0, 0, 0);
        DateTime Gelecek = DateTime.Today + GunSayisi;
        Console.WriteLine("{ 0} gün sonra günlerden { 1}dir.", gun, Gelecek.DayOfWeek);
        Console.ReadLine();
    }
}
