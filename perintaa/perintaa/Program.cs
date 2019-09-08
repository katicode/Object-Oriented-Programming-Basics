using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perintaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Mopo mopo = new Mopo();
            mopo.SetHinta(100);
            mopo.SetMerkki("Jupiter");
            mopo.SetMoottori("Sachs");

            Console.WriteLine(mopo.GetMerkki() + " " + mopo.GetMoottori() + " " + mopo.GetHinta());

            Console.WriteLine(mopo); //mopo luokan tostring metodi

            Console.ReadKey();
        }
    }
}
