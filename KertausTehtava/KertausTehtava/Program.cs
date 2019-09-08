using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KertausTehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            string laji = ""; //esitelty main-funktion sisällä -> ei näy aliohjelmissa, alkuarvoksi tyhjä merkkijono

            while (true)
            {
                Console.Write("Anna laji: ");
                laji = Console.ReadLine(); //lajille annetaan arvoksi se mitä käyttäjä kirjoittaa ruudulle, luetaan se
                if (laji.Length==0) //jos käyttäjä ei kirjoita mitään niin silmukka loppuu
                {
                    break;
                }

                bool ok=onkoHevonen(laji); //tämän metodin pitää palauttaa totuuarvo pääohjelmaan, boolean, true/false
                //ok:lle palautuu arvo true tai false
                if (ok==true)
                {
                    Console.WriteLine(laji + " on hevonen");
                }
                else
                {
                    Console.WriteLine(laji + " ei ole hevonen");
                }
            }
            Console.WriteLine("Ohjelma päättyi! Paina jotain näppäintä.");
            Console.ReadKey(); //kysyy näppäimistöltä annettavan merkin, luetaan yksi merkki
            //vs. ReadLine = lukee yhden rivin
        }

        static bool onkoHevonen(string laji) //aliohjelmaan tuotu pääohjelmasta muuttuja laji, käsitellään sitä samalla nimellä myös täällä
        {
            laji = laji.ToLower(); //muuttaa muuttujan laji -arvon pieniksi kirjaimiksi ennen vertailua
            if (laji == "hevonen") //== yhtäsuuruusvertailu
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
