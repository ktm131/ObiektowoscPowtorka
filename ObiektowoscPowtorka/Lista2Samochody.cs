using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    class Lista2Samochody
    {
        private LinkedList<Samochod> lista2;

        public Lista2Samochody()
        {
            lista2 = new LinkedList<Samochod>();
        }

        public void Wjedz(Samochod s,bool koniec = true)
        {
            if(koniec)
            {
                lista2.AddLast(s);
            }
            else
            {
                lista2.AddFirst(s);
            }
        }

        public Samochod Wyjedz(bool koniec = true)
        {
            if (koniec)
            {
                Samochod s = lista2.LastOrDefault();
                lista2.RemoveLast();
                return s;
            }
            else
            {
                Samochod s = lista2.FirstOrDefault();
                lista2.RemoveFirst();
                return s;
            }
         }


    }
}
