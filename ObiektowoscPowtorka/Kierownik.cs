using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    public class Kierownik : Osoba, IPracownik
    {
        private string dzial;

        public string Dzial
        {
            get { return dzial; } 
            set { dzial = value; }
        }

        public Kierownik() 
        {

        }

        public Kierownik(string imie, string nazwisko, string data, string pesel, string dzial) : base(imie,nazwisko,data,pesel)
        {
            this.Dzial = dzial;
        }

        public override string ToString()
        {
            return String.Format("{0} Dział: {1}", base.ToString(), Dzial);
        }

        public void Pracuj()
        {
            Console.WriteLine("Kieruję działem: " + this.Dzial);
        }

        public new void Funkcja1()
        {
            Console.WriteLine("To jest funkcja1 z klasy kierownik");
        }
    }
}
