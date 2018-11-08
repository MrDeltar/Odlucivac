using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odlucivac
{
    struct Odluke
    {
        public string odluka;
    }
    class Program
    {
        //list za unesene odluke
        static List<Odluke> popisOlduka = new List<Odluke>();

        static void Main(string[] args)
        {
            Console.WriteLine("***Program nasumicno odabere jednu od upisanih mogucih odluka***\n***Za prestanak upisa upisite (Dosta)***\n***Zadnji unos(Dosta) se nece uracunavati u odluke***");
            // unos korisnikovih odluka (korisnik unosi koliko hoce odluka)
            int brojac = 0;
            while (true)
            {
                brojac += 1;
                Console.WriteLine("{0}. odluka: ", brojac);
                Odluke novi = new Odluke();
                string unos = Console.ReadLine();

                if (unos == "Dosta" || unos == "dosta")
                {
                    break;
                }
                novi.odluka = unos;
                //dodavanje u listu Odluke
                popisOlduka.Add(novi);
            }
            //nasumicni odabir
            Random odabir = new Random();
            int broj = odabir.Next(1,brojac);
            //ispis odabrane odluke
            Console.WriteLine("Odabrana je {0}. odluka.", broj);
            //prevencija automatskog zatvaranja console
            Console.ReadLine();

        }
    }
}
