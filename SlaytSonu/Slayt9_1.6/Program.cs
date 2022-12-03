using System.Reflection;
using System;

class Program
{
    public static void Goster(oto Oto)
    {
        Console.WriteLine(Oto.Tur); //Hata ulaşamaz
        Console.WriteLine(Oto.MotorGucu);
        Console.WriteLine(Oto.Tork);
        Console.WriteLine(Oto.Renk);
    }
    static void Main(string[] args)
    {
        oto otol = new oto
        (75, 100, "Kırmızı");
        Goster(oto1);
        Console.WriteLine("-----------------.");
        model1 oto2 = new model1("Fiat", 100, 110, "Beyaz");
        Goster(oto2);
        Console.WriteLine("-----------------.");
        model2 oto3 = new model2("Renault", 100, 120, "Siyah");
        Goster(oto3);
        Console.ReadLine();
    }
}
