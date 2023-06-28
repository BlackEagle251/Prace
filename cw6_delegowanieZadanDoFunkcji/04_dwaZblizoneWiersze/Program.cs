using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_dwaZblizoneWiersze
{

    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

            int[] closestRows = FindClosestRows(array);
            Console.WriteLine($"Najbardziej zbliżone wiersze: {closestRows[0]}, {closestRows[1]}");
            Console.Read();
        }

        static int[] FindClosestRows(int[,] array)
        {
            int rowCount = array.GetLength(0);
            int columnCount = array.GetLength(1);

            int minDifference = int.MaxValue;
            int[] closestRows = new int[2];

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = i + 1; j < rowCount; j++)
                {
                    int difference = CalculateDifference(array, i, j, columnCount);

                    if (difference < minDifference)
                    {
                        minDifference = difference;
                        closestRows[0] = i;
                        closestRows[1] = j;
                    }
                }
            }

            return closestRows;
        }

        static int CalculateDifference(int[,] array, int i, int j, int columnCount)
        {
            int difference = 0;

            for (int k = 0; k < columnCount; k++)
            {
                int elementDifference = array[i, k] - array[j, k];
                difference += elementDifference * elementDifference;
            }

            return difference;
        }
    }
}
