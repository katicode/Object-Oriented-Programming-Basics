using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perintaa
{
    class Mopo:Kulkuneuvo //mopolla on jo olemassa merkki ja hinta, perii Kulkuneuvon tiedot
        //mopo laajentaa ominaisuuksia
    {
        private string moottori;

        //getteri ja setteri Penan tyyliin
        public void SetMoottori(string moottori)
        {
            this.moottori = moottori;
        }
        public string GetMoottori()
        {
            return this.moottori;
        }
        public override string ToString() //tällä voidaan tulostaa olion tiedot
        {
            return this.GetMerkki() + " " + this.GetMoottori() + " " + this.GetHinta();
        }
    }
}
