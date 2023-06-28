using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace informacjeoPrzedmiocie
{
    struct Przedmiot
    {
        public float waga;
        public int wartosc;
        public string klasaRzadkosci;
        public string typ;
        public string nazwaWlasna;

        public void wypelnijPrzedmiot(float waga, int wartosc, string klasaRzadkosci, string typ, string nazwaWlasna)
        {
            this.waga = waga;
            this.wartosc = wartosc;
            this.klasaRzadkosci = klasaRzadkosci;
            this.typ = typ;
            this.nazwaWlasna = nazwaWlasna;
        }

        public void wyswietlInformacje()
        {
            Console.WriteLine("Nazwa przedmiotu: " + nazwaWlasna);
            Console.WriteLine("Typ: " + typ);
            Console.WriteLine("Klasa Rzadkości: " + klasaRzadkosci);
            Console.WriteLine("Waga: " + waga);
            Console.WriteLine("Wartość: " + wartosc + " sztuk złota");
        }
    }

    class Program
    {
        static void Main()
        {
            Przedmiot[] przedmioty = new Przedmiot[3]; // Przykładowa tablica trzech przedmiotów
            przedmioty[0].wypelnijPrzedmiot(1.5f, 10, "zwyczajny", "broń", "Miecz");
            przedmioty[1].wypelnijPrzedmiot(2.0f, 50, "rzadki", "zbroja", "Pancerz Najemnika");
            przedmioty[2].wypelnijPrzedmiot(0.5f, 100, "epicki", "amulet", "Amulet Nekromanty");

            Console.WriteLine("Przedmiot 1:");
            przedmioty[0].wyswietlInformacje();

            Console.WriteLine("\nPrzedmiot 2:");
            przedmioty[1].wyswietlInformacje();

            Console.WriteLine("\nPrzedmiot 3:");
            przedmioty[2].wyswietlInformacje();

            Przedmiot losowyPrzedmiot = losujPrzedmiot(przedmioty);
            Console.WriteLine("\nWylosowany przedmiot:");
            losowyPrzedmiot.wyswietlInformacje();

            Console.Read();
        }

        static Przedmiot losujPrzedmiot(Przedmiot[] przedmioty)
        {
            Random rand = new Random();
            int index = rand.Next(przedmioty.Length); // Losuje indewks przedmiotu

            //Prawdopodobieństwo wylosowania przedmiotu zależy od jego klasy rzadkości
            int rzadkosc = rand.Next(1, 101); // Losuj liczbę od 1 do 100

            if(rzadkosc <=50)
                return przedmioty[index]; // 50% szans na wylosowanie przedmiotu
            else if(rzadkosc <= 80)
            {
                //15% szans na wylosowanie unikalnego przedmiotu
                for (int i = 0; i < przedmioty.Length; i++)
                {
                    if (przedmioty[i].klasaRzadkosci == "unikalny")
                        return przedmioty[i];
                }
            }
            else
            {
                // 5% szans na wylosowanie epickiego przedmiotu
                for (int i = 0;i < przedmioty.Length;i++)
                {
                    if (przedmioty[i].klasaRzadkosci == "epicki")
                        return przedmioty[i];
                }
            }

            return przedmioty[index]; // zwróć losowy przedmiot, jeśli nie udało się znaleźć odpowiedniej klasy rzadkości
        }
    }
}
