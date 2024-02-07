// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace Tester_różnych_algorytmów_sprawdzania_pierwszości;

public static class Program
{
    public static void Main()
    {
        Dictionary<OgolneSprawdzaniePierwszosci.CzyPierwsza, Wynik_Iteracji> wynik = new();

        OgolneSprawdzaniePierwszosci.CzyPierwsza[] algorytmy =
        {
            OgolneSprawdzaniePierwszosci.CzyPierwszaOptymalnie,
            OgolneSprawdzaniePierwszosci.CzyPierwszaPodstawowo,
            OgolneSprawdzaniePierwszosci.CzyPierwszaPrymitywnie
        };

        Console.Write("Podaj ile elementów: ");
        uint n = Convert.ToUInt32(Console.ReadLine());

        uint [] tab = new uint[n];

        tab.WypelnijLosowo();

        Console.WriteLine(tab[1]);
        Console.Write("\n");
        Console.WriteLine(tab.DoTekstu());

        //wyniki = new TimeSpan[t.Length];

        Stopwatch czasomierz = new();
        foreach (var item in algorytmy)
        {
            Wynik_Iteracji a = new Wynik_Iteracji();
            tab.WypelnijLosowo();
            czasomierz.Restart();
            for (uint i = 0; i < tab.Length; i++)
            {
                if (item(tab[i]))
                    a.ile_pierwszych++;

            }
            czasomierz.Stop();
            a.t = czasomierz.Elapsed / tab.Length;
            wynik.Add(item, a);
            Console.WriteLine(a);
        }
    }
}

public struct Wynik_Iteracji
{
    public uint ile_pierwszych = 0;
    public TimeSpan t;

    public Wynik_Iteracji()
    { }

    public override string ToString()
        => String.Join("   ", ile_pierwszych, t);
}