using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_n_liczbParzystych
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj ilość liczb parzystych do wygenerowania:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Metoda 1:");

            Random random = new Random();
            int liczV1 = 0;
            int wygenerowaneV1 = 0;

            while (liczV1 < n)
            {
                int liczba = random.Next(-8, 9);
                if (liczba % 2 ==0)
                {
                    Console.Write(liczba);
                    if (liczV1 < n - 1)
                        Console.Write(", ");
                    liczV1++;
                    wygenerowaneV1++;
                   
                }

                
            }

            Console.WriteLine();
            Console.WriteLine("Liczba losowań (Metoda 1): " + wygenerowaneV1);

            Console.WriteLine();
            Console.WriteLine("Metoda 2:");

            int liczV2 = 0;
            int wygenerowaneV2 = 0;

            while (liczV2 < n)
            {
                int liczba = random.Next(-4, 5) * 2;
                Console.Write(liczba);
                if (liczV2 < n - 1)
                    Console.Write(", ");
                liczV2++;
                wygenerowaneV2++;
            }

            Console.WriteLine();
            Console.WriteLine("Liczba losowań (Metoda 2: " + wygenerowaneV2);

            Console.ReadKey();


        }
    }
}
