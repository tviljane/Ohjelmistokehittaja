using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna Celcius-aste niin muutan sen Fahrenheiteiksi!");
            double cel = double.Parse(Console.ReadLine());

            double fah = cel * 1.8 + 32;
            
            Console.WriteLine(fah);

        }
    }
}
