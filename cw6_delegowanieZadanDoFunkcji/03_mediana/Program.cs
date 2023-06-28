using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_mediana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczba = { 5, 2, 8, 1, 9, 3 };
            int mediana = obliczMediane(liczba);
            Console.WriteLine($"Mediana: {mediana}");
            Console.Read();
        }

        static int obliczMediane(int[] liczba)
        {
            int dlugosc = liczba.Length;
            Array.Sort(liczba);
            int srodkowyIndex = dlugosc / 2;

            if (dlugosc == 0)
            {
                //Liczba elementów jest parzysta, średnia z dwóch wartości środkowych
                int mediana1 = liczba[srodkowyIndex - 1];
                int mediana2 = liczba[srodkowyIndex];
                return (mediana1 + mediana2 /2);
            }
            else
            {
                // Liczba elementów jest nieparzysta, środkowa wartość
                return liczba[srodkowyIndex];
            }
        }
    }
}
