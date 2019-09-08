using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskuLaskin
{
    class Program
    {
        static void Main(string[] args)
        {
            //käyttäjältä kysytään kaksi lukua, ohjelma tulostaa summan tai erotuksen tai molemmat
 // lyhyt parsinta: luku1 = Int32.Parse(Console.ReadLine()); luetaan merkkijono näppäimistöltä, parsitaan se int muuttujaksi luku1
            int luku1, luku2;
            while (true)
            { 
                try 
                { 
                    Console.Write("Anna luku 1: ");
                    string s1 = Console.ReadLine();
                    if (s1.Length == 0) //jos pituus 0 eli tyhjä merkkijono niin lopetetaan toisto
                    {
                        break;
                    }
                    Console.Write("Anna luku 2: " );
                    string s2 = Console.ReadLine();
                    if (s2.Length==0) //jos pituus 0 niin lopetetaan toisto
                    {
                        break;
                    }

                    luku1 = Int32.Parse(s1);
                    luku2 = Int32.Parse(s2);

                    int tulos = laske('+', luku1, luku2); //ynnaLasku niminen aliohjelma minne viedään kaksi parametria (muuttujan arvot)
                    //aliohjelma laskee arvot yhteen, palauttaa tuloksen
                    tulosta("Summa", tulos);
                    tulos = laske('-', luku1, luku2); //Console.WriteLine("Erotus= "+luku1-luku2);
                    tulosta("Erotus", tulos);
                }
                catch(FormatException fe) //nyt ohjelma ei kaadu, formatexception kun parsitaan, exception toimii kaikkiin virheisiin
                //joskus hyvä tehdä niin, että kohdennetaan poikkeus tiettyyn poikkeukseen. voi olla useampi catch
                {
                    Console.WriteLine("Anna lukuja ensi kerralla!");
                }
                catch (Exception e) //tämmöistä ei voi tapahtua tässä ohjelmassa? kaikki formatexception
                {
                    Console.WriteLine("Jokin tuntematon poikkeus");
                }
            }
            Console.Write("Ohjelma päättyi! Paina jotain näppäintä.");
            Console.ReadKey();

        }


        private static void tulosta(string s, int tulos)
        {
            Console.WriteLine(s+"= " + tulos); //string s on summa tai erotus, riippuen mikä aliohjelmaan on ylhäältä viety
        }

        private static int laske(char c, int luku1, int luku2) //private, ohjelman yksityinen aliohjelma, kukaan muu ei pääse
        {
            int tulos = 0;
            if (c == '+')
            {
                tulos = luku1 + luku2;
            }
            else if (c == '-')
            {
                tulos = luku1 - luku2;
            }
            return tulos;

        }
    }
}
