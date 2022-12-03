using System;

class A
{
    public void Metot1()
    { Metot2(); }
    public void Metot2()
    { Console.WriteLine("A sınıfı"); }
}
class B : A
{
    public new void Metot2()
    { Console.WriteLine("B sınıfı"); }
}
class Ana
{
    static void Main()
    {
        B b = new B();
        b.Metot1();
    }
}

class A
{
    public int OzellikA
;
    public A(int a)
    { OzellikA = a; }
}
class B : A
{
    public int OzellikB
;
    public B(int b, int a) : base(a)
    { OzellikB = b; }
}
class C : B
{
    public int OzellikC;



    public C(int c, int b, int a) : base
    (b, a
    )
    { OzellikC = c; }
    static void Main()
    {
        C nesne = new C(12, 56, 23);
        Console.WriteLine
        (nesne.OzellikA + "+nesne.OzellikB+" + nesne.OzellikC);
        Console.ReadLine();
    }
}
