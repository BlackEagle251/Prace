using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_sortowanieBabelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 5, 2, 8, 1, 9, 3, 6, 6, 7, 4 };

            sortowanieBabelkowe(tablica);
            foreach (int num in tablica)
            {
                Console.WriteLine(num + " ");
            }
            Console.ReadLine();
        }
        static void sortowanieBabelkowe(int[] tablica)
        {
            int n = tablica.Length;
            bool zamiana;

            for (int i = 0; i < n; i++)
            {
                zamiana = false;

                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        //Zamiana miejscami
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;

                        zamiana = true;
                    }
                }

                //Jeśli wewnętrzna pętla nie dokonała żadnej zamiany, oznacza to, że tablica jest już posortowana
                if(!zamiana)
                {
                    break;
                }
            }

        }
    }
}
