using System;
namespace PrgDil3
{
    class Deneme
    {
        public int a;
        public int b;
        public Deneme(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}

class Program
{
    static void Main()
    {
        PrgDil3.Deneme d = new PrgDil3.Deneme(1, 2);
        Console.WriteLine(d.a);
        Console.WriteLine(PrgDil3.Deneme.Topla(2, 3));
        Console.ReadLine();

    }
}
