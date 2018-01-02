using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    public class Garaz
    {
        public static int LiczbaSamochodow;

        static Garaz()
        {
            LiczbaSamochodow = 0;
        }

        public string Nazwa { get; set; }

        private Stack<Samochod> samochody;

        public Garaz()
        {
            this.samochody = new Stack<Samochod>();
        }

        public Garaz(string nazwa) : this()
        {
            this.Nazwa = nazwa;
        }

        public void Wjedz(Samochod s)
        {
            LiczbaSamochodow++;
            this.samochody.Push(s);
        }

        public Samochod Wyjedz()
        {
            LiczbaSamochodow--;
            return this.samochody.Pop();
        }

        public Samochod PokazPierwszyDoWyjazdu()
        {
            return this.samochody.Peek();
        }
    }
}
