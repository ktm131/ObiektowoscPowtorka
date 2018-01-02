using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObiektowoscPowtorka
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p = new Pracownik("Jan","Kowalski","1981-01-02","81010212345","Pracownik działu produkcji");
            Console.WriteLine(p.ToString());
            Pracownik p1 = new Pracownik("Adam", "Brzozowski", "1990-02-10", "90021012345", "Pracownik działu produkcji");
            Pracownik p2 = new Pracownik("Michał", "Brzozowski", "1990-02-10", "90021012345", "Pracownik działu produkcji");

            Kierownik k = new Kierownik("Janusz", "Iksiński", "1976-05-09", "76050912345", "Dział produkcji");
            Console.WriteLine(k.ToString());

            List<IPracownik> listaPracownikow = new List<IPracownik>();
            listaPracownikow.Add(p);
            listaPracownikow.Add(k);

            foreach(IPracownik ip in listaPracownikow)
            {
                ip.Pracuj();
            }
            Console.WriteLine("Sortowanie: #########################################################");

            List<Pracownik> pracownicy = new List<Pracownik>() { p, p1, p2 };
            pracownicy.Sort();

            foreach(Pracownik pr in pracownicy)
            {
                Console.WriteLine(pr);
            }


            Console.WriteLine("Klonowanie: #########################################################");
            Pracownik klon = (Pracownik)p.Clone();
            klon.Imie = "XXXX";
            Console.WriteLine(p);
            Console.WriteLine(klon);

            Console.WriteLine("Zespol: #########################################################");
            Zespol z = new Zespol();
            z.Nazwa = "Zespol 1";
            z.Kierownik = k;
            z.AddRange(pracownicy);

            Console.Write(z.ToString());

            Console.WriteLine("Garaż: #########################################################");
            Samochod s1 = new Samochod("Ford", "Mondeo");
            Samochod s2 = new Samochod("Volkswagen", "Passat");
            Samochod s3 = new Samochod("Fiat", "Uno");
            Samochod s4 = new Samochod("Ford", "Tranzit");

            Garaz g = new Garaz("Garaz 1");

            g.Wjedz(s1);
            g.Wjedz(s2);
            g.Wjedz(s3);
            g.Wjedz(s4);

            Samochod wyjechal = g.Wyjedz();
            Console.WriteLine(wyjechal.Marka + " " + wyjechal.Model);

            Samochod dowyjazdu = g.PokazPierwszyDoWyjazdu();
            Console.WriteLine(dowyjazdu.Marka + " " + dowyjazdu.Model);

            Samochod wyjechal1 = g.Wyjedz();
            Console.WriteLine(wyjechal1.Marka + " " + wyjechal1.Model);

            Console.WriteLine(Garaz.LiczbaSamochodow);

            Garaz g1 = new Garaz("Garaz 2");
            g1.Wjedz(new Samochod("Toyota", "Corolla"));

            Console.WriteLine(Garaz.LiczbaSamochodow);

            p.Funkcja();
            k.Funkcja();
            k.Funkcja1();

            Console.ReadKey();
        }
    }
}
