using System;

namespace Harjoituksia2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anna kolme lukua kerron mikä niistä on suurin.");

            Console.Write("Luku 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Luku 2: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Luku 3: ");
            int z = int.Parse(Console.ReadLine());

            int num = Math.Max(x, y);
            int nums = Math.Max(z, num);

            Console.Write("Suurin luku on: " + nums);

        }
    }
}
