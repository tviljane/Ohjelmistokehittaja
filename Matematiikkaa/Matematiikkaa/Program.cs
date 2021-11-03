using System;

namespace Matematiikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Peruslaskut joulupukki = new Peruslaskut();
            int x1 = joulupukki.Summa(4, 5);
            int x2 = joulupukki.Erotus(5, 4);
            double x3 = joulupukki.Osamaara(4, 5);
            int x4 = joulupukki.Tulo(5, 4);
            Console.WriteLine("Lukujen {0} ja {1} summa, erotus, osamäärä ja tulos ovat {2}, {3}, {4} ja {5}", 4, 5, x1, x2, x3, x4);
            Peruslaskut kukkakaali = new Peruslaskut();*/

            Pankkitili jyri = new Pankkitili("Jyri", "Lindroos", "123456-1234", 100.10);
            Console.WriteLine(jyri.Näytäsaldo());
            jyri.Pano(200);
            Console.WriteLine(jyri.Näytäsaldo());
            jyri.Otto(50.51);
            Console.WriteLine(jyri.Näytäsaldo());
            jyri.Otto(250);

        }
    }
}
