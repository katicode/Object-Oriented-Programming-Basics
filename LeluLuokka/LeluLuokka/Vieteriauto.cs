using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeluLuokka
{
    //vieteriauto perii lelu-luokasta ominaisuudet ja metodit (sekä oletusmuodostimen)
    class Vieteriauto : Lelu
    {
        public int nopeus;

        //oletusmuodostin peritään lelu-luokalta, mutta tehdään Vieteriautolle omakin, jotta saadaan nopeus määritettyä
        //käytetään base -> haetaan nimi ja paino määritykset lelu-luokan oletusmuodostimelta
        public Vieteriauto() : base()
        {
            nopeus = 0;
        }

        //tehdään vieteriauto-luokalle oma muodostin kolmella parametrilla, jossa voidaan määrittää myös nopeus
        public Vieteriauto(string nimi, int paino, int nopeus)
        {
            this.nimi = nimi;
            this.paino = paino;
            this.nopeus = nopeus;
        }

        public void TulostaVieteriautonTiedot()
        {
            Console.WriteLine("Vieteriauton  tiedot: ");
            Console.WriteLine("Vieteriauton nimi on " + nimi + " ja paino on " + paino + " kg ja nopeus on " + nopeus + " km/h.");
        }

        //vaihtoehtona TulostaVieteriautonTiedot olisi voinut tehdä ylikirjoituksen lelu-luokan metodille TulostaTiedot
        //alla esimerkki mahdollisesta ylikirjoituksesta:
        //public new void TulostaTiedot()
        //{
        //    Console.WriteLine("Vieteriauton  tiedot: ");
        //    Console.WriteLine("Vieteriauton nimi on " + nimi + " ja paino on " + paino + " kg ja nopeus on " + nopeus + " km/h.");
        //}

        public void Kiihdyta()
        {
            nopeus++; //nopeus kasvaa yhdellä
            Console.WriteLine("Vieteriauton " + this.nimi + " vauhti kiihtyy ja nopeus on nyt " + nopeus + " km/h.");
        }


    }
}
