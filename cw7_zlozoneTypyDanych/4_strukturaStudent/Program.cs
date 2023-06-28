using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_strukturaStudent
{
    enum Plec
    {
        Mezczyzna,
        Kobieta
    }

    struct Student
    {
        public string nazwisko;
        public int nrAlbumu;
        public double ocena;
        public Plec plec;

        public void WypelnijStudenta(string nazwisko, int nrAlbumu, double ocena, Plec plec)
        {
            this.nazwisko = nazwisko;
            this.nrAlbumu = nrAlbumu;
            this.ocena = Math.Max(2.0, Math.Min(5.0, ocena)); // Ogranicz ocenę do zakresu 2.0 - 5.0
            this.plec = plec;
        }

        public void WyswietlStudenta()
        {
            Console.WriteLine("Nazwisko: " + nazwisko + ", Nr albumu: " + nrAlbumu + ", Ocena: " + ocena + ", Płeć: " + plec);
        }
    }

    class Program
    {
        static void Main()
        {
            Student[] grupa = new Student[5]; // Tablica 5 studentów

            grupa[0].WypelnijStudenta("Kowalski", 12345, 4.5, Plec.Mezczyzna);
            grupa[1].WypelnijStudenta("Nowak", 23456, 3.7, Plec.Kobieta);
            grupa[2].WypelnijStudenta("Smith", 34567, 5.5, Plec.Mezczyzna); // Ocena zostanie ograniczona do 5.0
            grupa[3].WypelnijStudenta("Johnson", 45678, 1.8, Plec.Kobieta); // Ocena zostanie ograniczona do 2.0
            grupa[4].WypelnijStudenta("Davis", 56789, 4.2, Plec.Mezczyzna);

            Console.WriteLine("Grupa studentów:");
            for (int i = 0; i < grupa.Length; i++)
            {
                grupa[i].WyswietlStudenta();
            }

            double srednia = ObliczSrednia(grupa);
            Console.WriteLine("\nŚrednia ocen: " + srednia);

            Console.Read();
        }

        static double ObliczSrednia(Student[] grupa)
        {
            double suma = 0;
            for (int i = 0; i < grupa.Length; i++)
            {
                suma += grupa[i].ocena;
            }
            return suma / grupa.Length;
        }
    }
}
