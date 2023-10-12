using System;
using System.Collections.Generic;

namespace Technovizz.Objekty
{
    public class CisticeAktovatory
    {
        public CisticeAktovatory(string nazev, string jeAktivni, string vyrobce, string pouziti, string nevhodneKombinace, string slozeniDle, List<string> slozeni)
        {
            Nazev = nazev;
            JeAktivni = jeAktivni;
            Vyrobce = vyrobce;
            Pouziti = pouziti;
            NevhodneKombinace = nevhodneKombinace;
            SlozeniDle = slozeniDle;
            Slozeni = slozeni;
        }

        public String Nazev { get; set; }
        public String JeAktivni { get; set; }
        public String Vyrobce { get; set; }
        public String Pouziti { get; set; }
        public String NevhodneKombinace { get; set; }
        public String SlozeniDle { get; set; }

        /* V JAKÉM POŘADÍ JSOU DATA ULOŽENA:
         0 - 1,3-dioxolan
         1 - (3-aminopropyl)triethoxysilan
         2 - 3-(trimethoxysilyl)-1-propanthiol
         4 - benzen-1,3-diol resorcinol
         5 - dichlormetan
         6 - ethanol
         7 - heptan
         8 - isopropanol
         9 - N-(3-(trimethoxysilyl)propyl)-1,2-ethandiamin
         10 - voda
         11 - voda demi
        */

        public List<string> Slozeni { get; set; }
    }
}
