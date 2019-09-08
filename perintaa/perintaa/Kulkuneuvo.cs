using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perintaa
{
    class Kulkuneuvo
    {
        private string merkki;
        private float hinta;

        //getterit ja setterit Penan tyyliin
        public void SetMerkki(string merkki)
        {
            this.merkki = merkki;
        }
        public void SetHinta(float hinta)
        {
            this.hinta = hinta;
        }
        public string GetMerkki()
        {
            return this.merkki;
        }
        public float GetHinta()
        {
            return this.hinta;
        }
    }
}
