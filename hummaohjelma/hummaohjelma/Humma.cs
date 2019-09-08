using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hummaohjelma
{
    class Humma //tämä ei ole suoritettava ohjelma, tämä on tietotyyppi
    {
        //luokka class Humma on paketti, minne laitetaan ominaisuuksia ja metodeja
        //luodaan otuksia tämän luokan pohjalta
        //tässä kaikki ominaisuudet, metodit mitä humma voi tehdä

        private string rotu; //yksityinen, tätä attribuuttia voidaan käyttää vain tämän luokan sisällä (ei esim pääohjelmassa)
        private int paino;

        public string Rotu { get => rotu; set => rotu = value; }
        public int Paino { get => paino; set => paino = value; }

        public void Hirnu() //metodit julkisia, jos private void=ei pysty pääohjelmassa tekemään
        {
            Console.WriteLine(this.rotu+" sanoo Iha-haa");
        }

        public void Syo(int maara) //suojataan ominaisuuksia, niiden arvoja = kapseloinnin ajatus
        {
            if (maara < 0) //humma ei voi syödä negatiivista määrää
            {
                return;
            }
            this.paino = this.paino + maara;
        }

    }
}
