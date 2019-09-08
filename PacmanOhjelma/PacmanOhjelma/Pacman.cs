using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanOhjelma
{
    class Pacman
    {
        public int pisteet;
        public int elamat;

        public Pacman()
        {
            pisteet = 0;
            elamat = 5;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("Pacmanin tiedot");
            Console.WriteLine("Pisteet: " + pisteet);
            Console.WriteLine("Elämät: " + elamat);
        }

        public void Syo(Hedelma fruit) //metodi vastaanottaa Hedelma-luokan olion
        {
            Console.WriteLine("Hedelmä syöty");
            fruit.Katoa(); //pystytään kutsumaan Hedelma-luokan metodia Katoa
        }

        public void VahennaElama()
        {
            elamat--; //vähennetään yksi elämä
        }
    }
}
