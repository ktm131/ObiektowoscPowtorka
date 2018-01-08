using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    class KolejkaSamochodow
    {
        private Queue<Samochod> kolejka;

        public KolejkaSamochodow()
        {
            kolejka = new Queue<Samochod>();
        }

        public void Wjedz(Samochod s)
        {
            kolejka.Enqueue(s);
        }

        public Samochod Wyjedz()
        {
            Samochod s = kolejka.Dequeue();
            
            return s;
        }

        public Samochod Pokaz()
        {
            return kolejka.Peek();
        }
        
    }
}
