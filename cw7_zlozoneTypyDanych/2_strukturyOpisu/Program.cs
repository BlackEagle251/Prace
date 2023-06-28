using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_strukturyOpisu
{
    struct Student
    {
        public string Imie;
        public int wiek;
        public string kierunek;
        public int identyfikator;
    }

    struct Przedmiot
    {
        public string Nazwa;
        public string idPrzedmiotu;
        public int punktyKredytowe;
        public string Wykladowca;
    }
    struct wykladowca
    {
        public string Imie;
        public string Nazwisko;
        public string tytulNaukowy;
        public string przedmiot;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Imie = "Andrzej Nosacz",
                wiek = 20,
                kierunek = "Informatyka",
                identyfikator = 1
            };

            Przedmiot przedmiot = new Przedmiot
            {
                Nazwa = "Programowanie",
                idPrzedmiotu = "PR01",
                punktyKredytowe = 10,
                Wykladowca = "dr inż Janusz Nosacz"
            };

            wykladowca wykladowca = new wykladowca
            {
                Imie = "Janusz",
                Nazwisko = "Nosacz",
                tytulNaukowy = "dr",
                przedmiot = "Programowanie"
            };

            Console.WriteLine("Informacje o kursie:");
            Console.WriteLine($"Student: {student.Imie}");
            Console.WriteLine($"Wiek: {student.wiek}");
            Console.WriteLine($"Kierunek: {student.kierunek}");
            Console.WriteLine($"Identyfikator: {student.identyfikator}");

            Console.WriteLine($"Przedmiot: {przedmiot.Nazwa}");
            Console.WriteLine($"Kod przedmiotu: {przedmiot.idPrzedmiotu}");
            Console.WriteLine($"Punkty kredytowe: {przedmiot.punktyKredytowe}");
            Console.WriteLine($"Wykładowca: {przedmiot.Wykladowca}");

            Console.WriteLine($"Wykładowca: {wykladowca.Imie} {wykladowca.Nazwisko}");
            Console.WriteLine($"Tytuł naukowy: {wykladowca.tytulNaukowy}");
            Console.WriteLine($"Prowadzony przedmiot: {wykladowca.przedmiot}");

            // Dodatkowe operacje na danych studenta przedmiotu i nauczyciela...

            Console.ReadLine();
        }
    }
}
