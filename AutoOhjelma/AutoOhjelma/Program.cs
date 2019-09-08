using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(); //luodaan olio auto1
            auto1.merkki = "Nissan"; //asetetaan merkki, malli ja bensan määrä
            auto1.malli = "Micra";
            auto1.bensanMaara = 35;

            auto1.NaytaTiedot();
            auto1.Kiihdyta();
            auto1.NaytaTiedot();
            auto1.Tankkaa(10);
            Console.WriteLine();

            Auto auto2 = new Auto("Honda", "Accord", 3); //luodaan olio auto2 käyttäen muodostinta
            auto2.NaytaTiedot();
            auto2.Kiihdyta();
            auto2.Jarruta();

            auto2.Tankkaa(10);

            Console.ReadKey();
        }
    }
}
