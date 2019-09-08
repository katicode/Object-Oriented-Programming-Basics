using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacman pacman = new Pacman(); //luodaan uusi olio pacman luokasta Pacman
            pacman.TulostaTiedot();
            Console.WriteLine();

            Hedelma fruit1 = new Hedelma();
            Hedelma fruit2 = new Hedelma();
            Hedelma fruit3 = new Hedelma();

            //Console.WriteLine(fruit1.nakyvissa);

            pacman.Syo(fruit1); //lähetetään Syo-metodille olio fruit1, parametrina

            Console.WriteLine("Mitkä hedelmät näkyvät?");
            Console.WriteLine(fruit1.nakyvissa);
            Console.WriteLine(fruit2.nakyvissa);
            Console.WriteLine(fruit3.nakyvissa);

            Console.WriteLine();
            Ghost ghost = new Ghost();
            ghost.SyoPacman(pacman);

            Console.WriteLine();
            pacman.TulostaTiedot();

            Console.ReadKey();
        }
    }
}
