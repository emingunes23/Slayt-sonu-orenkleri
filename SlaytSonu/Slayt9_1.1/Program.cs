using System;

class oto
{
    protected double boy = 5;
    protected double agirlik = 800; protected string renk = "Sarı";
    public void goster()
    {
        Console.WriteLine("Boy=" + boy);
        Console.WriteLine("Ağırlık=" + agirlik);
        Console.WriteLine("Renk=" + renk);

    }
}
class model1 : oto
{
    public string tur;
    public int silindir_sayisi;
    public int subap_sayisi;
    public int tork;
    public int guc;
    public void ozellikyaz()
    {
        Console.WriteLine("Tür=" + tur);
        Console.WriteLine("Boy=" + boy);
        Console.WriteLine("Ağırlık=" + agirlik);
        Console.WriteLine("Silindir Sayisi =" + silindir_sayisi);
        Console.WriteLine("Subap Sayısı=" + subap_sayisi);
        Console.WriteLine("Tork=" + tork);
        Console.WriteLine("Güç=" + guc);


    }
}
class model12 : oto
{
    public double model12_boy
    {
        get { return boy; }
        set { boy = value; }
    }
    public double model12_agirlik
    {
        get { return agirlik; }
        set { agirlik = value; }
    }
    public string model12_renk
    {
        get { return renk; }
        set { renk = value; }
    }
    public string tur = "Hatchback";
    public int silindir_sayisi = 8; public int subap_sayisi = 16;
    public int tork = 300;
    public int guc = 210;
    public void ozellikyaz()
    {
        Console.WriteLine("Tür=" + tur);
        Console.WriteLine("Boy=" + model12_boy);
        Console.WriteLine("Ağırlık=" + model12_agirlik);
        Console.WriteLine("Renk=" + model12_renk);
        Console.WriteLine("Silindir Sayisi=" + silindir_sayisi);
        Console.WriteLine("Subap Sayısı=" + subap_sayisi);
        Console.WriteLine("Tork=" + tork);
        Console.WriteLine("Güç=" + guc);

    }
    public static void Main()
    {
        model12 mdl = new model12();
        mdl.ozellikyaz();
        Console.ReadLine();
    }
}