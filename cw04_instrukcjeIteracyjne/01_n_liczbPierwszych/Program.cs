using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_n_liczbPierwszych
{
    internal class Program
    {
        static bool liczbaPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;

                    for (int i = 2; i <= Math.Sqrt(liczba); i++)
                    {
                        if (liczba % i == 0)
                        return false;
                    }
            }
            return true;
        }
        static void Main()
        {
            Console.WriteLine("Podaj ilość liczb pierwszych do wyświetlenia:");
            int n = Convert.ToInt32(Console.ReadLine());

            int licz = 0;
            int obecnaLiczba = 2;

            while (licz < n)
            {
                if (liczbaPierwsza(obecnaLiczba))
                {
                    Console.WriteLine(obecnaLiczba);
                    licz++;
                }

                obecnaLiczba++;
            }
            Console.ReadKey();

        }
    }
}
