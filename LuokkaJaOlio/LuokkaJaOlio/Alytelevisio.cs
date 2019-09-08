using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuokkaJaOlio
{
    class Alytelevisio
    {
        //ominaisuudet
        public bool paalla; //arvoina true tai false, on päällä tai ei ole
        string merkki;
        int hinta;
        string vari;

        //oletusmuodostin
        public Alytelevisio()
        {
            paalla = false;
            merkki = "";
            hinta = 0;
            vari = "musta";
        }
        //toinen muodostin, kun halutaan antaa merkki ja hinta oliota luodessa
        public Alytelevisio(string p_merkki, int p_hinta) //muodostin kahdella parametrilla
        {
            paalla = false;
            merkki = p_merkki;
            hinta = p_hinta;
            vari = "musta";
        }

        //metodit
        public void TulostaTiedot() //tulostaa olion tiedot
        {
            Console.WriteLine("Älytelevision merkki on " + merkki + " ja hinta on " + hinta + " ja väri on " + vari);
            if (paalla == true)
            {
                Console.WriteLine(this.merkki+ " on päällä.");
            }
            else
            {
                Console.WriteLine(this.merkki + " ei ole päällä.");
            }
        }
        public void Kaynnisty()
        {
            paalla = true;
        }
        public void Sammu()
        {
            paalla = false;
        }
        public void TingiHinnasta(string arvo) 
        {
            if (arvo == "kyllä") //jos käyttäjä haluaa alennuksen niin alennetaan hintaa 100
            {
                hinta = hinta-100; 
            }
            else //jos ei niin hinta pysyköön samana mikä oli alunperin
            {
                return;
            }
        }

        public void MuutaTiedot(bool paalla, string p_merkki, int p_hinta, string p_vari)
        { //olion tiedot muutetaan sellaisiksi, jotka parametrit tänne viedään
            this.paalla = paalla;
            this.merkki = p_merkki;
            this.hinta = p_hinta;
            this.vari = p_vari;
        }
        public void SetMerkki(string p_merkki)
        {
            merkki = p_merkki;
        }
        public string GetMerkki()
        {
            return this.merkki;
        }
        public void SetHinta(int p_hinta)
        {
            hinta = p_hinta;
        }
        public int GetHinta()
        {
            return this.hinta;
        }
        public void SetVari(string p_vari)
        {
            vari = p_vari;
        }
        public string GetVari()
        {
            return this.vari;
        }
    }
}
