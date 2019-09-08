using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hummaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Humma humma = new Humma();
            humma.Rotu = "Arabi"; //käytetään metodinimeä Rotu
            humma.Paino = 300;

            Console.WriteLine("Humman rotu= " + humma.Rotu + " ja paino= " + humma.Paino);

            Humma humma2 = new Humma();
            humma2.Rotu = "Suomenhevonen";
            humma2.Paino = 500;

            Console.WriteLine("Humma 2:n rotu= " + humma2.Rotu + " ja paino= " + humma2.Paino);

            humma2.Hirnu(); //tavallinen metodi, pitää olla sulkeet perässä
            humma.Hirnu();

            humma.Syo(50); //maara=50
            Console.WriteLine("Humman rotu= " + humma.Rotu + " ja paino= " + humma.Paino);

            humma.Syo(-100); //maara=-100
            Console.WriteLine("Humman rotu= " + humma.Rotu + " ja paino= " + humma.Paino);


            Console.ReadKey();
        }
    }
}
