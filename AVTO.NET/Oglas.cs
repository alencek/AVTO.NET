using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTO.NET
{
    public class Prodajalec
    {
        public string ime { set; get; }
        public string priimek { set; get; }
        public string lokacija { set; get; }
        public int mobStevilka { set; get; }


        public Prodajalec()
        {
            ime = "defaultName";
            priimek = "deafultLastName";
            lokacija = "defaultLokacija";
            mobStevilka = 000000000;
        }
    }



   public class Oglas : Prodajalec
    {
        public string znamka { set; get; }
        public string model { set; get; }
        public int prevozenihKm { set; get; }
        public int cena { set; get; }
        public int letnik { set; get; }
        public string slika { set; get; }


        public Oglas(string z, string m, int p, int c, int l, string s, string pi, string pp, string pl, int pm)
        {
            znamka = z;
            model = m;
            prevozenihKm = p;
            cena = c;
            letnik = l;
            slika = s;
            ime = pi;
            priimek = pp;
            lokacija = pl;
            mobStevilka = pm;
        }
        public Oglas()
        {
            znamka = "Ford";
            model = "Focus";
            prevozenihKm = 100000;
            cena = 20000;
            letnik = 2010;
            slika = "images/rs.jpg";
            ime = "defaultName";
            priimek = "deafultLastName";
            lokacija = "defaultLokacija";
            mobStevilka = 000000000;
        }
    }

    
}
