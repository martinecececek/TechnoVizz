using System;

namespace Technovizz.Objekty
{
    public class Project
    {
        public Project(string tl, string nazev, Material material, string popis, string sklo, string temp, string trh, string imds)
        {
            TL = tl;
            Nazev = nazev;
            Material = material;
            ZkracenyPopis = popis;
            Sklo = sklo;
            Temp = temp;
            Trh = trh;
            Temp = temp;
            IMDS = imds;
        }

        public String TL { get; set; }
        public String Nazev { get; set; }
        public Material Material { get; set; }
        public String ZkracenyPopis { get; set; }
        public String Sklo { get; set; }
        public String Temp { get; set; }
        public String Trh { get; set; }
        public String IMDS { get; set; }
    }
}
