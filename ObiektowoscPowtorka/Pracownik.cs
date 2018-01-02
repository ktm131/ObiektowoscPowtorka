using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    public class Pracownik : Osoba, IPracownik, IComparable, ICloneable
    {
        private string rola;

        public string Rola
        {
            get { return rola; }
            set { rola = value; }
        }
        

        public Pracownik() 
        {

        }

        public Pracownik(string imie, string nazwisko, string data, string pesel, string rola) : base(imie,nazwisko,data,pesel)
        {
            this.rola = rola;
        }

        public override string ToString()
        {
            return String.Format("{0} Rola: {1}", base.ToString(),Rola);
        }

        public void Pracuj()
        {
            Console.WriteLine("Pracuje sobie...");
        }

        public int CompareTo(object obj)
        {
            Pracownik inny = (Pracownik)obj;

            if(this.Nazwisko.CompareTo(inny.Nazwisko)==1)
            {
                return 1;
            }
            else if(this.Nazwisko.CompareTo(inny.Nazwisko) == 0)
            {
                if(this.Imie.CompareTo(inny.Imie)==1)
                {
                    return 1;
                }
                else if(this.Imie.CompareTo(inny.Imie) == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public object Clone()
        {
            return new Pracownik(this.Imie, this.Nazwisko, this.DataUrodzenia.ToShortDateString(), this.Pesel, this.Rola);
        }

        public override void Funkcja()
        {
            Console.WriteLine("To jest funkcja z klasy pracownik");
        }
    }
}
