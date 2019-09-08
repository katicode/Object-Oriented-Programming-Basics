using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuokkaJaOlio
{
    class Program
    {
        static void Main(string[] args)
        {
            Alytelevisio tv1 = new Alytelevisio(); //luodaan ensimmäinen olio, tv1 ja se saa arvot oletusmuodostimesta
            Alytelevisio tv2 = new Alytelevisio("LG", 700); //tv2 saa jo luodessa kaksi arvoa

            tv2.Kaynnisty(); //käynnistetään tv2

            Console.Write("Telvisio 1:n tiedot: ");
            tv1.TulostaTiedot();
            Console.Write("Telvisio 2:n tiedot: ");
            tv2.TulostaTiedot();

            Alytelevisio tv3 = new Alytelevisio(); //kysytään käyttäjältä tiedot kolmannelle oliolle

            Console.WriteLine("Anna älytelevision merkki: ");
            string s = Console.ReadLine();
            tv3.SetMerkki(s);
            Console.WriteLine("Anna älytelevision hinta: ");
            s = Console.ReadLine(); 
            tv3.SetHinta(Int32.Parse(s));
            Console.WriteLine("Haluatko tinkiä hinnasta? Vastaa kyllä tai ei.");
            s = Console.ReadLine();
            tv3.TingiHinnasta(s);
            Console.WriteLine("Anna älytelevision väri: ");
            s = Console.ReadLine();
            tv3.SetVari(s);

            Console.Write("Telvisio 3:n tiedot: ");
            tv3.TulostaTiedot();

            Console.WriteLine("Päivitetäänpä televisio 1:n ja 2:n tietoja. Paina enteriä jatkaaksesi ");
            Console.ReadKey();

            Console.WriteLine();
            tv1.MuutaTiedot(true,"Samsung",1000,"valkoinen"); //annetaan tv1:lle uudet tiedot MuutaTiedot metodilla
            Console.WriteLine("Televisio 1:n päivitetyt tiedot ovat: ");
            tv1.TulostaTiedot();

            tv2.Sammu(); //sammutetaan tv2
            Console.WriteLine();
            Console.WriteLine("Televisio 2:n päivitetyt tiedot ovat: ");
            tv2.TulostaTiedot();

            Console.ReadKey();
        }

    }
}
