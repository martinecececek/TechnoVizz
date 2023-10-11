using System;
using System.Collections.Generic;
namespace Technovizz.Objekty
{
    public class Granulaty
    {
        public Granulaty(string nazev, string typ, string xk, string jeAktivni, string vyrobceDodavatel, string pouziti, string kombinaceS, string cisteni, List<string> nevhodneKombinace, string slozeniDle, List<string> slozeni)
        {
            Nazev = nazev;
            Typ = typ;
            XK = xk;
            JeAktivni = jeAktivni;
            VyrobceDodavatel = vyrobceDodavatel;
            Pouziti = pouziti;
            KombinaceS = kombinaceS;
            Cisteni = cisteni;
            NevhodneKombinace = nevhodneKombinace;
            SlozeniDle = slozeniDle;
            Slozeni = slozeni;
        }


        public String Nazev { get; set; }
        public String Typ { get; set; }
        public String XK { get; set; }
        public String JeAktivni { get; set; }
        public String VyrobceDodavatel { get; set; }
        public String Pouziti { get; set; }
        public String KombinaceS { get; set; }
        public String Cisteni { get; set; }
        public List<String> NevhodneKombinace { get; set; }
        public String SlozeniDle { get; set; }

        /* V JAKEM PORADI JSOU DATA ULOZENA: 
          0 - 2,2,6,6-tetramethyl-4-piperidinestery C12-21 a C18 
          1 -nenasyc.MK	4,4'-isopropylidendifenol	
          2 - 4,5-dichloro-2-oktyl-3(2H)-isothiazolon (DCOIT)	
          3 - benzinová frakce, hydrogen. težká parafínová	
          4 - carbon black (uhlíková čerň)	
          5 - diisodecylftalát (DIDP)	
          6 - ethylenpropylendienový kaučuk (EPDM)	
          7 - chlorid cínatý (SnCl2)	
          8 - chlorid cínatý dihydrát (SnCl2.2H2O)	
          9 - kaolin, +Ca	
          10 - mastek (Mg₃Si₄O₁₀(OH)₂)	
          11 - minerální olej bílý, ropný	
          12 - oxid zinečnatý ZnO	
          13 - polyethylen (PE)	
          14 - polyethylen (PE)	
          15 - polypropylen (PP)	
          16 - polypropylen (PP)	
          17 - polyvinylchlorid (PVC)	
          18 - skelná vlákna (GF)	
          19 - sojový olej epoxidovaný	
          20 - styren-ethylen/butylen-styren blokový kopolymer (SEBS)	
          21 - termoplastický elastomer styrenový (TPS-SEBS)	
          22 - termoplastický elastomer vulkanizovaný (TPV - EPDM+PP)	
          23 - uhličitan vápenatý (CaCO3)	
          24 - vápenec (CaCO3+další)	
          25 - NEDEKLAROVANÉ PIGMENTY	
          26 - NEDEKLAROVANÉ SLOŽKY
        */

        public List<String> Slozeni { get; set; }
    }
}
