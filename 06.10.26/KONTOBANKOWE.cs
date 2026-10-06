using System;
using System.Collections.Generic;
using System.Text;

namespace _06._10._26
{
    internal class KontoBankowe
    {
        // Pola
        // Właściwości
        // Cechy
        // Atrybuty
        private decimal _saldo;
        private string _nrKonta;
        private string _wlasciel;

        // hermetyzacja/enkapsulacja
        // gettery settery
        public decimal Saldo
        {
            get { return _saldo; }
        }

        public string Wlasciciel
        {
            get { return _wlasciel; }
            set
            {
                // walidacja
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _wlasciel = value;
                }
                else
                {
                    Console.WriteLine("Błąd: Nazwa właściciela nie może być pusta!");
                }
            }
        }

        // konstruktory
        public KontoBankowe()
        {
            _wlasciel = "Nieznany";
            _saldo = 0;

            Console.WriteLine("Utworzono puste konto.");
        }

        // stwórz konstruktor, który zna tylko właściciela i resztę ustawia sam
        public KontoBankowe(string nowyWlasciciel, decimal startoweSaldo)
        {
            _wlasciel = nowyWlasciciel;

            // walidacja salda (nie powinno być ujemne)
            _saldo = startoweSaldo;

            // generowanie nr konta

            // powinno jeszcze wypisać jaki nr ma konto
            Console.WriteLine($"Utworzone nowe konto dla: {_wlasciel} z saldem: {_saldo} PLN.");
        }

        // metody
        // funkcje obiektów
        public void Wplac(decimal kwota)
        {
            // walidacja kwoty
            _saldo += kwota;
            Console.WriteLine($"Wpłacono: {kwota} PLN. Aktualny stan konta {_saldo} PLN.");
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Właściciel: {_wlasciel}");
            Console.WriteLine($"Stan konta: {_saldo} PLN");
            // nr konta
        }
    }
}