﻿using System;

namespace harjoituksia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku 0-9");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {

                case (0):
                    Console.WriteLine("Nolla");
                    break;
                case (1):
                    Console.WriteLine("Yksi");
                    break;
                case (2):
                    Console.WriteLine("Kaksi");
                    break;
                case (3):
                    Console.WriteLine("Kolme");
                    break;
                case (4):
                    Console.WriteLine("Neljä");
                    break;
                case (5):
                    Console.WriteLine("Viisi");
                    break;
                case (6):
                    Console.WriteLine("Kuusi");
                    break;
                case (7):
                    Console.WriteLine("Seitsemän");
                    break;
                case (8):
                    Console.WriteLine("Kahdeksan");
                    break;
                case (9):
                    Console.WriteLine("Yhdeksän");
                    break;

                default:
                    Console.WriteLine("Anna kelvollinen luku!");
                    break;
            }

        }
    }
}
