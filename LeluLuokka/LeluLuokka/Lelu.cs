using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeluLuokka
{
    class Lelu
    {
        public string nimi;
        public int paino;
        //Jos paino olisi private, se ei näkyisi luokan ulkopuolelle. Private ei myöskään periydy.
        //Pidetään painon tyyppinä public, sillä haluamme käyttää painoa myös vieteriauto-luokassa.
        //Jos paino olisi protected, se näkyisi periytyvissä luokissa, mutta se ei näkyisi luokan ulkopuolella.
        //Painoa ei siis pystyisi muuttamaan luokan ulkopuolella. Jos paino olisi protected, niin pitäisi
        //tehdä jokin metodi, jonka avulla painoon pääsisi käsiksi.

        public Lelu() //oletusmuodostin
        {
            this.nimi = " ";
            this.paino = 0;
        }

        public Lelu(string nimi, int paino) //muodostin kaikilla parametreilla
        {
            this.nimi = nimi;
            this.paino = paino;
        }

        public void TulostaTiedot()
        //jos tämä metodi olisi private, niin siihen ei pääsisi käsiksi luokan ulkopuolella.
        //jos metodi olisi protected, niin metodi periytyy, mutta siihen ei pääse käsiksi luokan ulkopuolella.
        //pidetään arvona public, sillä haluamme pääohjelmassa käyttää TulostaTiedot metodia.

        {
            Console.WriteLine("Lelun tiedot: ");
            Console.WriteLine("Lelun nimi on " + nimi + " ja lelun paino on " + paino + " kg.");
        }


    }
}
