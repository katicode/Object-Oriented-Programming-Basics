using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiililaiteLuokka
{
    //ohjelmasta löytyy olioita, luokkia, periviä luokkia, staattisia attribuutteja ja metodeita,
    //kapselointia sekä abstrakti luokka ja metodi
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan uusi olio tabletti-luokasta
            Tabletti tabletti1 = new Tabletti("Huawei", 20, 15, "valkoinen");
            tabletti1.TulostaTiedot();
            //laitetaan tabletti päälle
            tabletti1.Paalla = true;
            //muutetaan väriä aksessorin kautta, jos käyttäjä ei kirjoittaisi mitään, väriksi jää valkoinen
            tabletti1.Vari = "musta";
            //muutetaan pituutta aksessorin kautta (tarkistus)
            tabletti1.Pituus = 18;
            //muutetaan leveyttä (ei onnistu koska aksessori tarkistaa arvon ja -6 ei ole kelvollinen. Arvoksi jää 15.)
            tabletti1.Leveys = -6;
            tabletti1.TulostaTiedot();
            Console.WriteLine();
            tabletti1.AvaaSovellus("AirBnB");
            //viedään olio tabletti1 metodiin ImuroiVirus
            tabletti1.ImuroiVirus(tabletti1);
            tabletti1.TulostaTiedot();
            Console.WriteLine();

            Tabletti tabletti2 = new Tabletti("Sony", 30, 20, "harmaa");
            tabletti2.TulostaTiedot();
            Console.WriteLine();

            //Alykello alykello1 = new Alykello(); 
            //alykello1.TulostaTiedot();
            //alykello1 saa arvot Mobiililaite-luokasta perityltä oletusmuodostimelta
            //mutta saa virheen koska Alykello-luokkaan tehtiin uusi muodostin
            // -> joten siirretty kommentteihin

            //tehdään uusi Alykello käyttäen uutta muodostinta, annetaan kaksi parametria
            Alykello alykello2 = new Alykello("Polar", 6);
            alykello2.TulostaTiedot();
            Alykello alykello3 = new Alykello("Apple", 8);
            alykello3.Paalla = true;
            alykello3.TulostaTiedot();
            Console.WriteLine();

            //tulostetaan Alykellojen lukumäärä staattisen metodin kautta
            //ei tarvitse luoda oliota. Metodia kutsutaan luokan nimellä.
            Alykello.TulostaLkm();
            //tulostetaan myös Tablettien lukumäärä staattisen metodin avulla
            Tabletti.TulostaLkm();


            Console.ReadKey();
        }
    }
}
