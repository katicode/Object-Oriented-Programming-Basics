using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeluLuokka
{
    class Lego : Lelu
    {
        //lego perii lelu-luokan ominaisuudet ja metodit sekä oletusmuodostimen
        //annetaan legolle 2 kpl omia ominaisuuksia:
        private string vari; //kapseloidaan vari, alempana tehdään metodi, jonka avulla tähän pääsee käsiksi
        public int pituus;

        public Lego(string nimi, int paino, string vari, int pituus)
        {
            this.nimi = nimi;
            this.paino = paino;
            this.vari = vari;
            this.pituus = pituus;
        }

        public string Vari //tehdään aksessori, jonka avulla voidaan muuttaa väriä
        {
            set //asetetaan varin arvo, setteri
            {
                if (value == "") //jos käyttäjä ei kirjoita mitään, asetetaan väriksi ei väriä
                {
                    vari = "ei väriä";
                }
                else //muutoin asetetaan väriksi käyttäjän kirjoittama arvo
                {
                    vari = value;
                }
            }
            get //getteri, viedään varin arvo
            {
                return vari;
            }
        }

        //ylikirjoitetaan lelu-luokan metodi TulostaTiedot -> new
        public new void TulostaTiedot()
        {
            Console.WriteLine("Legon tiedot: ");
            Console.WriteLine("Legon nimi on " + nimi + " ja paino on " + paino + " kg ja väri on " + vari + " ja pituus "+pituus + " cm.");
        }
    }
}
