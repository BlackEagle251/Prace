using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_wypelnianieSpiralne
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            int[,] tablica = new int[n, n];
            int liczba = 1;
            int k = 0, l = 0;
            int m = n, p = n;

            while (k < m && l < p)
            {
                for (int i = l; i< p; i++) // wypełnianie górnej krawędzi
                {
                    tablica[k, i] = liczba;
                    liczba++;
                }
                k++;

                for (int i = k; i < m; i++) // wypełnianie prawej krawędzi
                {
                    tablica[i, p - 1] = liczba;
                    liczba++;
                }
                p--;

                if (k < m)
                {
                    for ( int i = p - 1; i >= l; i--) // wypełnianie dolnej krawędzi
                    {
                        tablica[m - 1, i] = liczba;
                        liczba++;
                    }

                    m--;

                    if (l < p)
                    {
                        for (int i = m -1; i >= k; i--) // wypełnianie lewej krawędzi
                        {
                            tablica[i, l] = liczba;
                            liczba++;
                        }
                        l++;
                    }
                }

                


            }

            // Wyświetlanie tablicy
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
