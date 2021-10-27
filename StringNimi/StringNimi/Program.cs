using System;

namespace StringNimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä on nimesi?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei, " + nimi);
        }
    }
}
