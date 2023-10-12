using System;
using System.Collections.Generic;

namespace Technovizz.Objekty
{
    public class KluzkyLak
    {
        public KluzkyLak(string nazev, string jeAktivni, string vyrobce, string pouziti, string nevhodneKombinace, string slozeniDle, List<string> slozeni)
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
         0 - 1,2-benzoisothiazol-3(2H)-on
         1 - 2-(diethylamino)ethan-1-ol
         2 - alifatický alkohol
         4 - alkyl polyglykolether
         5 - cyklohexyldimethylamin
         6 - diethanolamin
         7 - ethan-1,2-diol
         8 - hexamethylendiisokyanát, oligomery
         9 - hexan-1,6-diyldiisokyanát
         10 - mastný aminalkyl, etoxylovaný
         11 - nonylfenol
         12 - polyethylenglykoltridecyletherfosfát
         13 - triethylamin
        */

        public List<String> Slozeni { get; set; }

    }
}
