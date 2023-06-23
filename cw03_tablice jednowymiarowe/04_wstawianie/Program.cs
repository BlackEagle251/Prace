using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_wstawianie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 2, 5, 9, 4, 1, 6, 2, 7, 3, 8 };

            wstawianieSortowanie(tablica);

            Console.WriteLine("Posortowana tablica:");
            foreach (int num in tablica)
            {
                Console.WriteLine(num + " ");
            }

            Console.ReadLine();
            
        }
        static void wstawianieSortowanie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 1; i < n; i++)
            {
                int klucz = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > klucz)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = klucz;
            }
        }
    }
}
