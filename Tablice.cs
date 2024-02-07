//using ExtensionMethods;
namespace Tester_różnych_algorytmów_sprawdzania_pierwszości;

static class RozszerzenieTablic
{
    static readonly Random RNG = new();

    public static void WypelnijLosowo(this uint [] tab, int max = Int32.MaxValue)
    {
        for (uint i = 0; i < tab.Length; i++)
        {
            tab[i] = Convert.ToUInt32(RNG.Next(max));
        }
    }

    public static string DoTekstu(this uint[] tab)
        => String.Join("\n", tab);
}
