using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiililaiteLuokka
{
    class Alykello : Mobiililaite
    {
        private double halkaisija;
        private double sade;
        //staattinen attribuutti, laskee montako Alykello-oliota on luotu
        private static int AlykellojenLkm;

        //muodostin määritellään ja haetaan tiedot aksessorien kautta
        public Alykello(string merkki, double halkaisija)
        {
            this.Merkki = merkki;
            this.halkaisija = halkaisija;
            this.Paalla = false;

            //lisää Alykellojen lukumäärää yhdellä, staattinen attribuutti = sama arvo kaikilla luokan olioilla
            AlykellojenLkm++;
        }

        public override double LaskeNeliot()
        {
            //Alykello on pyöreä, joten sen pinta-ala lasketaan eri kaavalla kuin suorakulmaisen tabletin
            sade = halkaisija / 2;
            neliot = Math.PI*sade*sade;
            return neliot;
        }

        //haetaan tulostukseen tiedot aksessorien kautta
        public void TulostaTiedot()
        {
            LaskeNeliot();
            Console.WriteLine("Merkki on " + Merkki);
            Console.WriteLine("Säde on " + sade + "cm ja neliösentit: " + neliot);
            if (Paalla == true)
            {
                Console.WriteLine(Merkki + " on päällä. ");
            }
            else
            {
                Console.WriteLine(Merkki + " ei ole päällä. ");
            }

        }

        //staattinen metodi. voidaan käsitellä vain staattisia attribuutteja.
        //tätä voi käyttää luomatta yhtäkään oliota.
        public static void TulostaLkm()
        {
            Console.WriteLine("Älykellojen lukumäärä on " + AlykellojenLkm);
        }
    }
}
