using System;

namespace Harjoituksia4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kolme lukua kerron mikä niistä on suurin.");

            Console.Write("Luku 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Luku 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Luku 3: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Luku 4: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Luku 5: ");
            int e = int.Parse(Console.ReadLine());

            int num1 = Math.Max(a, b);
            int num2 = Math.Max(c, num1);
            int num3 = Math.Max(d, num2);
            int num4 = Math.Max(e, num3);

            Console.Write("Suurin luku on: " + num4);

        }
    }
}
