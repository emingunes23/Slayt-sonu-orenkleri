using System;
delegate Ana temsilciAna();
delegate Yavru temsilciYavru();
class Ana { }
class Yavru : Ana { }
class program
{
    static Ana MetotAna()
    {
        return new Ana();
    }
    static Yavru MetotYavru() { return new Yavru(); }
    static void Main()
    {
        temsilciAna nesneAna = new temsilciAna(MetotYavru);
        nesneAna += new temsilciAna(MetotAna); nesneAna();
        temsilciYavru nesneYavru = new temsilciYavru(MetotYavru);
        nesneYavru();
    }
}

