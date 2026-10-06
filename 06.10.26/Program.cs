using _06._10._26;

namespace ProgramowanieObiektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Tworzenie obiektu
            KontoBankowe pusteKonto = new KontoBankowe();

            // Różne działania na obiektach
            //pusteKonto._saldo = 10000;
            //Console.WriteLine(pusteKonto.Saldo);
            pusteKonto.WyswietlInformacje();

            // Tworzenie obiektu
            KontoBankowe kontoJana = new KontoBankowe("Jan Kowalski", 1500.59m);

            kontoJana.Wplac(500);

            kontoJana.WyswietlInformacje();

            // Rzeczy z komentarzy: nrKonta, gettery settery, walidacje
            // metoda Wyplac

            // Zabezpieczenie operacji pinem. Każde konto powinno mieć ustawiony przez usera kod PIN
            // PIN ma 4 cyfry i nadaje się go przy zakładaniu konta.
            // Wpłata oraz wypłata wymaga od teraz wpisania poprawnego PINu
            // przykład: mojeKonto.Wyplac(100, "1234") -> "NIEPOPRAWNY PIN!" albo "Wypłacam 100 PLN."
        }
    }
}