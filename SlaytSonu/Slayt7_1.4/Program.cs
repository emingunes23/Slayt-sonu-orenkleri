
using System;
namespace isimalani1
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
}
namespace isimalani2
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
    }
}
class Program
{
    static void Main()
    {
        isimalani1.Deneme d1 = new isimalani1.Deneme();
        isimalani2.Deneme d2 = new isimalani2.Deneme();
        Console.ReadLine();
    }
}


