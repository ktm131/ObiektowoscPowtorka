using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    public class Samochod
    {
        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Samochod(string marka, string model)
        {
            this.Marka = marka;
            this.Model = model;
        }

    }
}
