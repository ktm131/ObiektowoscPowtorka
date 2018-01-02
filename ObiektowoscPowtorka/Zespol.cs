using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    public class Zespol : List<Pracownik>
    {
        private string nazwa;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        private Kierownik kierownik;

        public Kierownik Kierownik
        {
            get { return kierownik; }
            set { kierownik = value; }
        }

        public int LiczbaPracownikow { get { return this.Count; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(this.Nazwa);
            sb.AppendLine();
            sb.AppendLine(Kierownik.ToString());
            sb.Append("liczba pracowników: ");
            sb.Append(LiczbaPracownikow);
            sb.AppendLine();

            foreach (Pracownik p in this)
            {
                sb.AppendLine(p.ToString());
            }

            return sb.ToString();
        }
    }
}
