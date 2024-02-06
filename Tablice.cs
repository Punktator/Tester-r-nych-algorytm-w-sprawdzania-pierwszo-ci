namespace Tester_różnych_algorytmów_sprawdzania_pierwszości;

class KlasaTablicowa
{
    internal uint[] tab;
    readonly Random RNG = new();

    public KlasaTablicowa(uint n)
    {
        this.tab = new uint[n];
    }

    public KlasaTablicowa() { }

    public void WypelnijLosowo(int max = Int32.MaxValue)
    {
        for (uint i = 0; i < tab.Length; i++)
        {
            this.tab[i] = Convert.ToUInt32(RNG.Next(max));
        }
    }

    public override string ToString()
        => String.Join("\n", this.tab);

    public uint Length =>
       Convert.ToUInt32(this.tab.Length);

    public uint this[uint indeks]
    {
        get
        {
            return this.tab[indeks];
        }
        set
        {
            this.tab[indeks] = value;
        }
    }

    public static implicit operator uint[](KlasaTablicowa tablica)
        => tablica.tab;

    public static implicit operator KlasaTablicowa(uint[] tablica)
    {
        KlasaTablicowa nowa_tablica = new();
        nowa_tablica.tab = tablica;
        return nowa_tablica;
    }
}
