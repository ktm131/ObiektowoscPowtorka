using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    public abstract class Osoba //pracownik{ osoba { } }
    {
        public Osoba()
        {

        }

        public Osoba(string imie, string nazwisko, string data, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = DateTime.Parse(data);
            this.pesel = pesel;
        }

        private string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        private string nazwisko;

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        private DateTime dataUrodzenia;

        public DateTime DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }

        private string pesel;

        public string Pesel
        {
            get
            {
                if (string.IsNullOrEmpty(pesel))
                {
                    return "00000000000";
                }
                else
                {
                    return pesel;
                }
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    pesel = "00000000000";
                }
                else
                {
                    pesel = value;
                }
               
            }
        }

        public override string ToString()
        {
            return String.Format("Imie: {0}, Nazwisko: {1}, Data urodzenia: {2}, PESEL: {3}"
                ,Imie,Nazwisko,DataUrodzenia.ToShortDateString(),Pesel);
        }

        public virtual void Funkcja()
        {
            Console.WriteLine("To jest funkcja z klasy osoba");
        }

        public void Funkcja1()
        {
            Console.WriteLine("To jest funkcja1 z klasy osoba");
        }
    }
}
