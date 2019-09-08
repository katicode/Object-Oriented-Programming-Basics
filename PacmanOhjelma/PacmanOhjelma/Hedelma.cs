using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanOhjelma
{
    class Hedelma
    {
        public bool nakyvissa;

        public Hedelma()
        {
            nakyvissa = true;
        }

        public void Katoa() //public ainoa sopiva valinta, jotta voidaan kutsua metodia toisesta luokasta
        {
            nakyvissa = false;
            Console.WriteLine("Hedelmä piilotettu");
        }
    }
}
