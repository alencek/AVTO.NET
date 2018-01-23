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


        public Oglas(string Znamka, string Model, int Prevozenih, int Cena, int Letnik, string Slika, string ProdajalecIme, string ProdalecPriimek, string ProdajalecLokacija, int ProdajalecMobi)
        {
            znamka = Znamka;
            model = Model;
            prevozenihKm = Prevozenih;
            cena = Cena;
            letnik = Letnik;
            slika = Slika;
            ime = ProdajalecIme;
            priimek = ProdalecPriimek;
            lokacija = ProdajalecLokacija;
            mobStevilka = ProdajalecMobi;
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
