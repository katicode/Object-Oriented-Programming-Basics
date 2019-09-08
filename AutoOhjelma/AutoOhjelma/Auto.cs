using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOhjelma
{
    class Auto
    {
        //attribuutit
        public string merkki;
        public string malli;
        public int bensanMaara;

        //muodostimet x 2
        public Auto()
        {
            //oletusmuodostin, mutta ei tällä kertaa anneta mitään arvoja. Tämä tässä vain jotta auto1 luonti toimii.
        }
        public Auto(string merkki, string malli, int bensanMaara)
        {
            this.merkki = merkki;
            this.malli = malli;
            this.bensanMaara = bensanMaara;
        }
        //metodit
        public void Jarruta()
        {
            Console.WriteLine("Auto " + merkki + " jarruttaa.");
        }
        public void Kiihdyta()
        {
            Console.WriteLine("Auto " + merkki +" kiihtyy.");
            bensanMaara = bensanMaara-1;
            if (bensanMaara<=2)
            {
                Console.WriteLine("Bensa on lopussa, mene tankkaamaan.");
            }
            else if (bensanMaara<=0)
            {
                Console.WriteLine("Bensa loppui. Auto jää tähän.");
            }
            else
            {
                Console.WriteLine("Bensaa on vielä, kiihdytä lisää!");
            }

        }
        public void NaytaTiedot()
        {
            Console.WriteLine("Auton merkki on " + merkki + " ja malli on " + malli + ". Bensaa on jäljellä " + bensanMaara + " litraa.");
        }
        public void Tankkaa(int litrat) //oletetaan että tankkiin mahtuu 40 litraa
        {
            if (bensanMaara+litrat<40) //jos tankattava litramäärä + tankissa oleva bensan määrä jää alle 40, tehdään tankkaus
            {
                bensanMaara = bensanMaara + litrat;
                Console.WriteLine("Tankataan "+litrat+" litraa. Tankkaus onnistui! Tankissa on nyt "+bensanMaara+" litraa.");
            }
            else //jos yritetään tankata liikaa
            {
                int liikatankkaus = bensanMaara + litrat - 40; //lasketaan paljonko yritettiin tankata liikaa, yli tankin kapasiteetin
                bensanMaara = 40; //bensaa tankattiin täysi tankki, enempää ei mahdu
                Console.WriteLine("Tankataan "+litrat+" litraa. Et voi tankata noin paljoa! Tankissa on nyt maksimimäärä eli "+bensanMaara+" litraa.");
                Console.WriteLine("Miksi ihmeessä halusit tankata " + liikatankkaus + " litraa enemmän kuin tankkiin mahtuu!");
            }
        }
    }
}
