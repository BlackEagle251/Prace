using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_wypelnianieRosnaco
{
    class Program
    {
        static void Main()
        {
            int[,] tablica = new int[10, 10];

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                if ( i % 2 == 0 ) // wiersze parzyste
                {
                     for (int j = 0; j < tablica.GetLength(1); j++)
                    {
                        tablica[i, j] = i * tablica.GetLength(1) + j + 1;
                    }
                }
                else // wiersze nieparzyste
                {
                    for (int j = tablica.GetLength(1) - 1; j >= 0; j--)
                    {
                        tablica[i, j] = (i + 1) * tablica.GetLength(1) - j;
                    }
                }
            }

            // wyświetlanie tablicy
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0;j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
