using System;
class Zaman
{
    public static void Main()
    {
        DateTime Tarih = DateTime.Today;
        Console.WriteLine("Kısa Tarih =" +Tarih.ToShortDateString());
        Console.WriteLine("Uzun Tarih =" +Tarih.ToLongDateString());
        Console.WriteLine("Şimdiki Yıl =" +Tarih.Year);
        Console.WriteLine("5 Yıl Sonrası =" +Tarih.AddYears(5));
        Console.WriteLine(Tarih.AddMonths(-5));
        Console.WriteLine(Tarih.AddDays(5));
        Console.WriteLine(Tarih.AddDays(-5));
        Console.WriteLine(Tarih.AddHours(23));
        Console.WriteLine(Tarih.AddMinutes(10));
        Console.WriteLine(Tarih.AddSeconds(10));
        Console.WriteLine(Tarih.AddMonths(-5));
        Console.WriteLine(Tarih.AddMilliseconds(1000));
        Console.WriteLine(Tarih.AddTicks(10));
        Console.ReadLine();
    }
}


