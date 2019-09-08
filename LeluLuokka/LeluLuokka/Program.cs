using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeluLuokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luodaan kaksi oliota luokasta Lelu. Ensimmäinen oletusmuodostimella, toiselle annetaan kaksi parametria.");
            Lelu lelu1 = new Lelu();
            lelu1.TulostaTiedot();

            Lelu lelu2 = new Lelu("Nallukka", 2);
            lelu2.TulostaTiedot();

            Console.WriteLine();

            Console.WriteLine("Luodaan kolme oliota luokasta Vieteriauto.");
            Console.WriteLine("Ensimmäinen oletusmuodostimella, toiselle ja kolmannelle annetaan arvot luontivaiheessa.");
            Console.WriteLine("Ensimmäisen tietojen tulostus Lelu-luokan metodilla, loput Vieteriauto-luokan metodilla.");
            Vieteriauto vieteriauto1 = new Vieteriauto();
            //tulostetaan vieteriauto1 tiedot käyttäen Lelu-luokan TulostaTiedot-metodia.
            //Tässä ei tulosteta nopeutta, joka on Vieteriauto-luokan oma ominaisuus
            vieteriauto1.TulostaTiedot();

            //Seuraavissa tulostetaan vieteriautojen tiedot luokan oman metodin TulostaVieteriautonTiedot-avulla
            //Ko. metodi huomioi myös nopeus-attribuutin
            Vieteriauto vieteriauto2 = new Vieteriauto("Matti", 5, 2);
            vieteriauto2.TulostaVieteriautonTiedot();

            Vieteriauto vieteriauto3 = new Vieteriauto("Pannu", 6, 5);
            vieteriauto3.TulostaVieteriautonTiedot();
            vieteriauto3.Kiihdyta();

            Console.WriteLine();
            Console.WriteLine("Tehdään yksi olio luokasta Lego");
            Lego lego1 = new Lego("Palikka", 1, "keltainen", 10);
            lego1.TulostaTiedot();
            lego1.Vari = "punainen"; //assessorilla päästään muuttamaan väriä -> lego1.vari ei ole mahdollinen koska vari=private
            lego1.TulostaTiedot();

            Console.ReadKey();
        }
    }
}
