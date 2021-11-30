using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio
{
    class Kirjat
    {
        private string knimi, tnimi, sivut, knum, tila;

        public Kirjat(string nimi, string tekija, string sivu, string id, string varaus)
        {
            knimi = nimi;
            tnimi = tekija;
            sivut = sivu;
            knum = id;
            tila = varaus;
        }
        
        public string tarkistaNimi()
        {

        if (tila == "Vapaana")
            {
                return knimi;
            }
        else
            {
                return "";
            }
        }

        public string tarkistaTekija()
        {

            if (tila == "Vapaana")
            {
                return tnimi;
            }
            else
            {
                return "";
            }
        }

        public string tarkistaSivu()
        {

            if (tila == "Vapaana")
            {
                return sivut;
            }
            else
            {
                return "";
            }
        }

        public string tarkistaId()
        {

            if (tila == "Vapaana")
            {
                return knum;
            }
            else
            {
                return "";
            }
        }

        public string palautus()
        {
            if (tila == "Varattu")
            {
                Console.WriteLine("Kirja on nyt palautettu.");
                return tila = "Vapaana";
            }
            else
            {
                Console.WriteLine("Et ole lainannut tätä kirjaa.");
                return "";
            }
        }

        public string lainaus()
        {
            if (tila == "Vapaana")
            {
                Console.WriteLine("Kirja on nyt lainattu.");
                return tila = "Varattu";
            }
            else
            {
                Console.WriteLine("Tämä kirja on varattu");
                return "";
            }
        }
    }
}
