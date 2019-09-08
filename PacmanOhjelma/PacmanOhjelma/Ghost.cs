using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanOhjelma
{
    class Ghost
    {
        public Ghost() { } //oletusmuodostin

        public void SyoPacman(Pacman pacman)
        {
            pacman.VahennaElama();
            Console.WriteLine("Pacman syöty");
        }
    }
}
