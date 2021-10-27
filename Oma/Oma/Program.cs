using System;

namespace Oma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hyvää ");
            Console.WriteLine("päivää");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Hyvää päivää, ");
            Console.Write(name);
            Console.WriteLine("!");
        }
    }
}
