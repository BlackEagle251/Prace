using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_sortowanieWybieranie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 5, 2, 8, 1, 9, 3, 6, 7, 4 };

            sortowanieWybieranie(tablica);

            Console.WriteLine("Posortowana tablica:");
            foreach (int num in tablica)
            {
                Console.WriteLine(num + " ");

            }
            Console.ReadLine();
        }
        static void sortowanieWybieranie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j= i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Zamiana miejscami elementu na pozycji i z najmniejszym elementem
                int temp = tablica[minIndex];
                tablica[minIndex] = tablica[i];
                tablica[i] = temp;
            }
        }
    }
}
