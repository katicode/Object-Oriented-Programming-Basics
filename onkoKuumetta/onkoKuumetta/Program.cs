using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onkoKuumetta
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                { 
                    Console.WriteLine("Onko kyseessä ihminen, koira vai hevonen?");
                    string laji = Console.ReadLine(); //luetaan vastaus string muuttujaksi laji
                    bool b = OnkoSopivaVastaus(laji); //tutkitaan antoiko käyttäjä jonkin kolmesta vaihtoehdosta
                    if (b == false) //jos ei ollut mikään annetuista kolmesta niin lopetetaan ohjelma
                    {
                        Console.WriteLine("Syötit jonkin muun kuin ihminen, koira tai hevonen. Ohjelma loppui!");
                        break;
                    }

                    Console.WriteLine("Anna kohteen ruumiinlämpötila?");
                    int lampotila = Int32.Parse(Console.ReadLine()); //luetaan vastaus ja parsitaan se luvuksi

                    TulostaKuumerajat();
                    Console.WriteLine();

                    bool ok = onkoKuumetta(laji, lampotila); //viedään laji ja lämpötila aliohjelmaan, tutkitaan onko kuumetta
                    if (ok == true) //tulostetaan onko lajilla kuumetta vai ei
                    {
                        Console.WriteLine("Kohteella " + laji + " on kuumetta");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Kohteella " + laji + " ei ole kuumetta");
                        Console.WriteLine();
                    }
                }
                catch(FormatException fe) //jos lämpötilan parsiminen ei onnistu, lopetetaan ohjelma
                {
                    Console.WriteLine("Annoit lämpötilaksi jonkin muun kuin luvun. Ohjelma loppui!");
                    break;
                }
            }
            Console.ReadKey();
        }

        private static bool OnkoSopivaVastaus(string laji)
        {
            laji = laji.ToLower();
            if (laji == "ihminen" ) //tutkitaan onko vastaus ihminen, koira tai hevonen
            {
                return true;
            }
            if (laji == "koira")
            {
                return true;
            }
            if (laji == "hevonen")
            {
                return true;
            }
            else
            {
                return false; //jos ei mikään näistä kolmesta niin palautetaan arvo false
            }
        }

        private static bool onkoKuumetta(string laji, int lampotila)
        {
            laji = laji.ToLower(); //muutetaan kaikki pieniksi kirjaimiksi, niin kirjoitusasu ei häiritse tulosta
            if (laji == "ihminen") //tutkitaan kaikki lajit onko kuumetta
            {
                if (lampotila > 37)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            if (laji == "koira")
            {
                if (lampotila > 39)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            if (laji == "hevonen")
            {
                if (lampotila > 38)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false; 
            //tänne ei oikeasti koskaan päästä, koska jo aiemmin on tutkittu, että käyttäjä syöttää jonkun yllä mainituista
        }

        private static void TulostaKuumerajat()
        {
            Console.WriteLine("Ihmisen kuumeraja on 37");
            Console.WriteLine("Koiran kuumeraja on 39");
            Console.WriteLine("Hevosen kuumeraja on 38");

        }
    }
}
