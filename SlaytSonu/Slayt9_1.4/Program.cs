using System;

public class Hayvan
{
    protected String a = "Hayvan.a";
    String b = "Hayvan.b"; //friendly
    private String c = "Hayvan.c";
    public String d = "Hayvan.d";
}
public class Kedi : Hayvan
{ // Türeyen

    public Kedi()
    {
        Console.WriteLine("Kedi olusturuluyor");
        Console.WriteLine(a);
        //Console.WriteLine(b); 
        // ! Hata ! erisemez ? 
        //Console.WriteLine(c); 
        // ! Hata ! erisemez ?
        Console.WriteLine(d);
    }



}
class deneme
{
    public static void Main(string[] args)
    {
        Kedi k = new Kedi();
        Console.ReadLine();
    }
}
