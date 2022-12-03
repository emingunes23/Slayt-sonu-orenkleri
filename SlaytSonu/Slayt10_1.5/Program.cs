using System;
delegate void OlayYoneticisi(); //Olay yöneticisi bildirimi
class AnaProgram
{
    static void Main()
    {
        AnaProgram nesne = new AnaProgram();
        nesne.Olay += new OlayYoneticisi(Metot);
        nesne.Olay();

    }
    static void Metot()
    {
        Console.WriteLine("Butona tıklandı.");
    }
    event OlayYoneticisi Olay;


}

