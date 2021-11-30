using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa kirjastoon!");
            


            Kirjat ekaKirja = new Kirjat("Ankka", "Marko Markonen", "372", "1", "Vapaana");
            Kirjat tokaKirja = new Kirjat("Kek", "Jorma Uotila", "123", "2", "Vapaana");
            Kirjat kolmasKirja = new Kirjat("Jorman elämä", "Moti Menetys", "3", "3", "Vapaana");
            Kirjat neljasKirja = new Kirjat("4", "Four", "4444", "4", "Vapaana");

            kysely();

            void selaa()
            {
                string[] selaus1 = { ekaKirja.tarkistaNimi(), ekaKirja.tarkistaTekija(), ekaKirja.tarkistaSivu(), ekaKirja.tarkistaId(), "" };
                string[] selaus2 = { tokaKirja.tarkistaNimi(), tokaKirja.tarkistaTekija(), tokaKirja.tarkistaSivu(), tokaKirja.tarkistaId(), "" };
                string[] selaus3 = { kolmasKirja.tarkistaNimi(), kolmasKirja.tarkistaTekija(), kolmasKirja.tarkistaSivu(), kolmasKirja.tarkistaId(), "" };
                string[] selaus4 = { neljasKirja.tarkistaNimi(), neljasKirja.tarkistaTekija(), neljasKirja.tarkistaSivu(), neljasKirja.tarkistaId(), "" };


                foreach (string taulukko1 in selaus1)
                {
                    Console.WriteLine(taulukko1);
                }

                foreach (string taulukko2 in selaus2)
                {
                    Console.WriteLine(taulukko2);
                }

                foreach (string taulukko3 in selaus3)
                {
                    Console.WriteLine(taulukko3);
                }

                foreach (string taulukko4 in selaus4)
                {
                    Console.WriteLine(taulukko4);
                }

                kysely();

            }

            void lainaa()
            {
                Console.WriteLine("Minkä kirjan haluat lainata?");
                string lainaavast = Console.ReadLine();

                switch(lainaavast)
                {
                    case ("1"):
                        ekaKirja.lainaus();

                        break;
                    case ("2"):
                        tokaKirja.lainaus();

                        break;
                    case ("3"):
                        kolmasKirja.lainaus();

                        break;
                    case ("4"):
                        neljasKirja.lainaus();

                        break;
                    default:
                        Console.WriteLine("Antamasi tunnus on väärin.");
                        
                        break;
                     
                }
                kysely();
            }

            void palauta()
            {
                Console.WriteLine("Minkä kirjan haluat palauttaa?");
                string palautavast = Console.ReadLine();

                switch (palautavast)
                {
                    case ("1"):
                        ekaKirja.palautus();

                        break;
                    case ("2"):
                        tokaKirja.palautus();

                        break;
                    case ("3"):
                        kolmasKirja.palautus();

                        break;
                    case ("4"):
                        neljasKirja.palautus();

                        break;
                    default:
                        Console.WriteLine("Antamasi tunnus on väärin.");

                        break;

                }
                kysely();
            }


            void kysely()
            {

                ALKU:

                Console.WriteLine("Haluatko selata, lainata vai palauttaa?");
                string vast = Console.ReadLine();

                switch(vast)
                {

                    case ("selata"):
                        selaa();
                        goto ALKU;

                        break;
                    case ("lainata"):
                        lainaa();
                        goto ALKU;

                        break;
                    case ("palauttaa"):
                        palauta();
                        
                        break;
                    default:
                        goto ALKU;

                       break;
                }
            }
        }
    }
}




