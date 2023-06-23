using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_zawartoscTablicy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;
            int[] tab = new int[rozmiar];
            Random losowy = new Random();

            //wypełnienie tablicy losowymi wartościami
            for (int i = 0; i < rozmiar; i++)
            {
                tab[i] = losowy.Next(1, 100);
            }

            Console.WriteLine("Tablica:");
            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine(tab[i] + " ");
            }

            Console.WriteLine("\nTablica od tyłu:");
            wyswietlOdwroconaTablice(tab);

            Console.ReadLine();

        }
        static void wyswietlOdwroconaTablice(int[] tablica)
        {
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tablica[i] + " ");
            }
        }

    }
}
