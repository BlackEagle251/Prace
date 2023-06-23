using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_trojkat
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj wysokość trójkąta (liczbę wierszy):");
            int wysokosc = Convert.ToInt32(Console.ReadLine());

            int maxSzerokosc = 2 * wysokosc - 1;

            for (int i = 1; i <= wysokosc; i++)
            {
                int liczPlus = 2 * i - 1;
                int liczSpacji = (maxSzerokosc - liczPlus) / 2;

                for (int j = 0; j <liczSpacji; j++)
                {
                    Console.Write(" ");
                }

                for ( int j = 0; j < liczPlus; j++)
                {
                    Console.Write("+");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
