using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_wypelnianieUzytownik
{
    internal class Program
    {
        static void Main()
        {
            int rozmiar;

            do
            {
                Console.Write("Podaj rozmiar tablicy (liczba całkowita większa od zera): ");
            } while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0);

            int[,] tablica1 = new int[rozmiar, rozmiar];
            int[,] tablica2 = new int[rozmiar, rozmiar];

            // Generowanie tablicy z zadania 1
            for (int i = 0; i < tablica1.GetLength(0); i++)
            {
                if (i % 2 == 0) // wiersze parzyste
                {
                    for (int j = 0; j < tablica1.GetLength(1); j++)
                    {
                        tablica1[i, j] = i * tablica1.GetLength(1) + j + 1;
                    }
                }
                else // wiersze nieparzyste
                {
                    for (int j = tablica1.GetLength(1) - 1; j >= 0; j--)
                    {
                        tablica1[i, j] = (i + 1) * tablica1.GetLength(1) - j;
                    }
                }
            }

            // Generowanie tablicy z zadania 2
            int liczba = 1;
            int k = 0, l = 0;
            int m = rozmiar, p = rozmiar;

            while (k < m && l < p)
            {
                for (int i = l; i < p; i++) // wypełnianie górnej krawędzi
                {
                    tablica2[k, i] = liczba;
                    liczba++;
                }
                k++;

                for (int i = k; i < m; i++) // wypełnianie prawej krawędzi
                {
                    tablica2[i, p - 1] = liczba;
                    liczba++;
                }
                p--;

                if (k < m)
                {
                    for (int i = p - 1; i >= l; i--) // wypełnianie dolnej krawędzi
                    {
                        tablica2[m - 1, i] = liczba;
                        liczba++;
                    }
                    m--;
                }

                if (l < p)
                {
                    for (int i = m - 1; i >= k; i--) // wypełnianie lewej krawędzi
                    {
                        tablica2[i, l] = liczba;
                        liczba++;
                    }
                    l++;
                }
            }

            // Wyświetlanie tablicy z zadania 1
            Console.WriteLine("Tablica z zadania 1:");
            for (int i = 0; i < tablica1.GetLength(0); i++)
            {
                for (int j = 0; j < tablica1.GetLength(1); j++)
                {
                    Console.Write(tablica1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Wyświetlanie tablicy z zadania 2
            Console.WriteLine("Tablica z zadania 2");
            for (int i = 0; i < tablica2.GetLength(0); i++)
            {
                for (int j = 0; j < tablica2.GetLength(1); j++)
                {
                    Console.Write(tablica2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
