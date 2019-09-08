using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiililaiteLuokka
{
    // Halusin tehdä työhöni abstraktin luokan. Mobiililaite-luokassa on yksi abstrakti metodi LaskeNeliot.
    // Koska luokassa on yksi abstrakti metodi, koko luokan on oltava abstrakti.
    // Abstraktista luokasta ei tehdä olioita. Siitä voidaan kylläkin periyttää luokkia normaalisti.
    // Abstrakti luokka on hahmotelma, jossa kerrotaan metoditasolla, mitä (perivässä) luokassa tulee olla.
    // Koodeja ei kuitenkaan ole varsinaisesti vielä kirjoitettu, ne kirjoitetaan sitten perivissä luokissa. 
    abstract class Mobiililaite
    {
        //asetetaan attribuutit privateiksi eli kapseloidaan ne, jotta niihin ei pääse ulkopuolelta käsiksi
        private string merkki;
        private bool paalla;

        //protected attribuutti neliot abstrakstin metodin tulosta varten -> jotta voidaan käyttää alaluokissa
        //neliösenttiä -> cm2
        protected double neliot;

        //oletusmuodostin, tehdään koska halutaan että tämä periytyy
        //jotta olioilla on oletusarvot merkille ja paalla-arvolle
        public Mobiililaite()
        {
            this.merkki = "";
            this.paalla = false;
        }

        //aksessorin perässä ei käytetä sulkuja
        public string Merkki
        {
            set
            {
                if (value == "") //jos käyttäjä syöttää tyhjän merkkijonon, merkkiä ei aseteta
                {
                    merkki = "ei merkkiä";
                }
                else //kunhan käyttäjä kirjoittaa jotakin, asetetaan se merkiksi
                {
                    merkki = value;
                }
            }
            get //pystyy hakemaan/tulostamaan merkin
            {
                return merkki;
            }
        }

        

        public bool Paalla //aksessori
        {
            set
            {
                if (value == true)
                {
                    paalla = true;
                }
                else
                {
                    paalla = false;
                }
            }
            get
            {
                return paalla;
            }
        }

        //normaali metodi AvaaSovellus
        public void AvaaSovellus(string sovellus)
        {
            Console.WriteLine("Sovellus " + sovellus + " on nyt auki.");
        }

        //abstrakti metodi, laskee mobiililaitteen näytön neliöt
        //metodia ei koodata tässä, vaan vasta perivässä luokassa
        abstract public double LaskeNeliot();
    }
}
