using System;

public class dizi
{
    static void Main()
    {
        // 1. ÖRNEK
        Random rand = new Random();
        int[] dizi = new int[20];
        char[] chr = new char[20];

        for (int i = 0; i < 20; i++)
        {
            dizi[i] = rand.Next(1, 51);
            chr[i] = (char)rand.Next(20, 126);
        }
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("{0,2} . değer {1,2} -> ", i, dizi[i]);
            for (int j = 0; j < dizi[i]; j++)
                Console.Write(chr[i]);
            Console.WriteLine();
        }







        Console.WriteLine("\n******************************************************\n");

        //2. ÖRNEK
        int[,] dizi2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        for (int i2 = 0; i2 < 3; i2++)
            for (int j2 = 0; j2 < 2; j2++)
            {
                Console.WriteLine(dizi2[i2, j2]);
            }






        Console.WriteLine("\n******************************************************\n");

        // 3. ÖRNEK
        int[][] dizi3 = new int[3][];
        dizi3[0] = new int[] { 1, 2 };
        dizi3[1] = new int[] { 3, 4, 5, 6, 7 };
        dizi3[2] = new int[] { 8, 9, 0 };

        foreach (int[] boyut in dizi3)
        {
            foreach (int eleman in boyut)
            {
                Console.Write("{0,3}", eleman);
            }
            Console.WriteLine();
        }






        Console.WriteLine("\n******************************************************\n");

        // 4. ÖRNEK
        int[,] d = { { 2, 3 }, { 4, 5 }, { 6, 7 } };
        d[2, 1] = 33;
        //d[2][1] = 33; 
        Console.WriteLine(d.GetValue(2, 1));
        int[][] dd = new int[2][];
        dd[0] = new int[2];
        dd[1] = new int[1];
        dd[0][0] = 23;
        dd[0][1] = 234;
        dd[1][0] = 44;
        Random rnd = new Random();
        int[] dizi4 = new int[3];
        dizi4[0] = rnd.Next(2, 10);
        dizi4[1] = rnd.Next(50);
        dizi4[2] = rnd.Next();
        Console.WriteLine(dizi4.GetValue(2));

        Console.WriteLine(dd[1][0]);




        Console.WriteLine("\n******************************************************\n");

        // 5. ÖRNEK
        string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
        Console.Write("aranan isim = ");
        string aranan = Console.ReadLine();
        foreach (string ss in isimler)
        {
            if (aranan.Equals(isimler[0]))
                Console.WriteLine("aranan isim bulundu...");
            else Console.WriteLine("isim yok");
        }






        Console.WriteLine("\n******************************************************\n");

        // 6. ÖRNEK
        int s1, s2, s3;
        Console.WriteLine("1. sayıyı girin : ");
        s1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. sayıyı girin : ");
        s2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3. sayıyı girin : ");
        s3 = Convert.ToInt32(Console.ReadLine());

        int enBuyuk = BuyukBul(s1, s2, s3);

        Console.WriteLine("En büyük: {0}\'dir.", enBuyuk);





        Console.WriteLine("\n******************************************************\n");

        // 7. ÖRNEK
        int[] dizi5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        DiziYaz(dizi5, 0);
        DiziYaz(dizi5, 1);
        DiziYaz(dizi5, 2);






        Console.WriteLine("\n******************************************************\n");

        // 8. ÖRNEK
        int x = 100;
        Console.WriteLine(x);

        DegerTipAktarim(x);
        Console.WriteLine(x);







        Console.WriteLine("\n******************************************************\n");

        // 9. ÖRNEK
        Console.WriteLine(Islem("topla", 3, 4, 7, 8));
        Console.WriteLine(Islem("carp", 5, 23, 6));






        Console.WriteLine("\n******************************************************\n");

        // 10. ÖRNEK
        Yaz(25);
        Yaz("Deneme1", "Deneme2");
        Yaz('a');
        Yaz('z', 1, 23f, 4, 56, "abc");






        Console.WriteLine("\n******************************************************\n");

        // 11. ÖRNEK
        Console.Write("Faktöriyelini alacağınız sayıyı giriniz :");
        int fak_değeri = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Girmiş olduğunuz sayının faktöriyeli :" +
                            Faktoriyel(fak_değeri));

    }






    // 6. örnek için
    static int BuyukBul(int a, int b)
    {
        if (a > b)
            return a;
        return b;
    }
    static int BuyukBul(int a, int b, int c)
    {
        return BuyukBul(a, BuyukBul(b, c));
    }



    // 7. örnek için
    static void DiziYaz(int[] a, int Sekil)
    {
        if (Sekil == 0)
        {
            foreach (Object o in a)
                Console.Write(o.ToString() + " ");
            Console.WriteLine();
        }
        else if (Sekil == 1)
        {
            int x = 1;
            foreach (Object o in a)
            {
                Console.Write("{0,5}", 0.ToString());
                if (x % 3 == 0)
                    Console.WriteLine();
                x++;
            }
        }
        else
        {
            foreach (Object o in a)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine();
        }
    }




    // 8. örnek için
    static void DegerTipAktarim(int Sayi)
    {
        Sayi = 30;
    }





    // 9. örnek için
    static int Islem(string a, params int[] sayilar)
    {
        if (a == "carp")
        {
            if (sayilar.Length == 0) return 1;
            int carpim = 1;
            foreach (int i in sayilar) carpim *= i;
            return carpim;
        }
        else if (a == "topla")
        {
            if (sayilar.Length == 0) return 0;
            int toplam = 0;
            foreach (int i in sayilar) toplam += i;
            return toplam;
        }
        else return 0;


    }




    // 10. örnek için
    static void Yaz(object o)
    {
        Console.WriteLine("1.Metot:" + o);
    }
    static void Yaz(params object[] o)
    {
        if (o.Length == 0) return;
        Console.Write("2.Metot:");
        foreach (object n in o)
            Console.Write(n.ToString() + " ");
        Console.WriteLine();
    }




    // 11. örnek için
    static int Faktoriyel(int a)
    {
        if (a == 0)
            return 1;
        return a * Faktoriyel(a - 1); //fonksiyon kendi içerisinde çağrıldı
    }

}