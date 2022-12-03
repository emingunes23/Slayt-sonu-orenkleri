using System;
 enum notu : byte { basarisiz, basarili }
 class Program
 {
 static void Main()
 {
notu a = notu.basarili;
 if (a == (notu)1)
 Console.Write("Başarılısınız");
 else
 Console.Write("Başarısızsınız");
        Console.ReadLine();
 }
 }