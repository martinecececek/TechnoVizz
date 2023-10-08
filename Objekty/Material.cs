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

        public bool ContainParemeter(string parametr)
        {
            if (SAP == parametr || Nazev == parametr)
            {
                return true;
            }
            return false;
        }


    }
}
