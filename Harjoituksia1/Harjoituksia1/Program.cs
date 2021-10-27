using System;

namespace Harjoituksia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kaksi lukua ja laitan ne suuruus järjestykseen");

            Console.Write("Luku 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Luku 2: ");
            int y = int.Parse(Console.ReadLine());

            int nump = Math.Min(x, y);
            int nums = Math.Max(x, y);

            Console.Write("Lukujärjestyksesi on: " + nump + ", " + nums);
         }
    }
}
