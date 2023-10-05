using System;

namespace Technovizz.Objekty
{
    public class Material
    {
        public Material(string sAP, string nazev, string typPripravku)
        {
            SAP = sAP;
            Nazev = nazev;
            TypPripravku = typPripravku;
        }

        public String SAP { get; set; }
        public String Nazev { get; set; }
        public String TypPripravku { get; set; }

    }
}
