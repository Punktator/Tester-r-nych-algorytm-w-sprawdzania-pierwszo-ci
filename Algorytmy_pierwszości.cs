using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester_różnych_algorytmów_sprawdzania_pierwszości;

static class OgolneSprawdzaniePierwszosci
{
    public delegate bool CzyPierwsza(ulong n);

    static public bool CzyPierwszaOptymalnie(ulong n)
    {
        switch (n)
        {
            case 0:
                return false;
            case 1: 
                return false;
        }
        if (n == 2 || n == 3)
            return true;
        if (n % 2 == 0)
            return false;

        for (ulong i = 5; i <= Math.Sqrt(n); i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }

    public static bool CzyPierwszaPodstawowo(ulong n)
    {
        switch (n)
        {
            case 0:
                return false;
            case 1:
                return false;
            case 2:
                return true;
        }
        if (n % 2 == 0)
            return false;

        for (ulong i = 3; i < Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    public static bool CzyPierwszaPrymitywnie(ulong n)
    {
        switch (n)
        {
            case 0:
                return false;
            case 1:
                return false;
        }

        for (ulong i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
