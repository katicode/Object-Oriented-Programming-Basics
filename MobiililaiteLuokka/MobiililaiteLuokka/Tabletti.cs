using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiililaiteLuokka
{
    //Tabletti luokka on periytetty luokasta Mobiililaite
    class Tabletti : Mobiililaite
    {
        //kaikki attribuutit on kapseloitu
        private string vari;
        private int pituus;
        private int leveys;

        //staattinen attribuutti, laskee montako tabletti-oliota on luotu
        private static int tablettienLkm;

        //muodostin neljällä parametrilla
        //määritellään ja haetaan aksessorien kautta
        //-> saadaan tiedot tarkistettua ja asetettua heti luodessa oliota
        public Tabletti(string merkki, int pituus, int leveys, string vari)
        {
            this.Merkki = merkki;
            this.Pituus = pituus;
            this.Leveys = leveys;
            this.Vari = vari;
            this.Paalla = false;
            //lisää tablettien lukumäärää yhdellä
            tablettienLkm++;
        }

        //Mobiililuokan abstraktia metodi LaskeNeliot
        //tabletti-luokkaa ei voisi tehdä ilman LaskeNeliot-metodia. Abstrakti luokka vaatii sen alaluokiltaan
        //LaskeNeliot metodin koodi kirjoitetaan vasta tänne perivään luokkaan
        public override double LaskeNeliot()
        {
            neliot = Pituus * Leveys;
            return neliot;
        }

        //haetaan tiedot aksessorien kautta
        public void TulostaTiedot()
        {
            LaskeNeliot();
            Console.WriteLine("Merkki on " + Merkki + " ja väri on " + Vari);
            Console.WriteLine("Pituus on " + Pituus + "cm ja leveys " + Leveys + "cm neliösentit: " + neliot);
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
            Console.WriteLine("Tablettien lukumäärä on " + tablettienLkm);
        }

        public string Vari
        {
            set
            {
                if (value == "") //jos käyttäjä syöttää tyhjän merkkijonon, väriä ei aseteta/muuteta
                {
                    return;
                }
                else //kunhan käyttäjä kirjoittaa jotakin, asetetaan se väriksi
                {
                    vari = value;
                }
            }
            get
            {
                return vari;
            }
        }
        public int Pituus //aksessori
        {
            set
            {
                if (value > 1) //jos pituus suurempi kuin 1 niin asetetaan arvo
                {
                    pituus = value;
                }
                else //jos jotain muuta niin pidetään entinen arvo eli haetaan (get) Pituus arvo
                {
                    pituus = Pituus;
                }
            }
            get
            {
                return pituus;
            }
        }

        public int Leveys //aksessori
        {
            set
            {
                if (value > 1) //jo leveys suurempi kuin 1 niin asetetaan arvo
                {
                    leveys = value;
                }
                else //jos jotain muuta niin pidetään entinen arvo
                {
                    leveys = Leveys;
                }
            }
            get
            {
                return leveys;
            }
        }

        //metodi ImuroiVirus sammuttaa laitteen
        //metodiin vastaanotetaan parametrina Tabletti-luokan olio
        public void ImuroiVirus(Tabletti tabletti)
        {
            Console.WriteLine("Latasit viruksen! Laite sammuu!");
            //sammutetaan laite
            tabletti.Paalla = false;
        }
    }
}
