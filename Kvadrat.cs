using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Kvadrat : Cetverokut
    {
        private float a;

        private Kvadrat()
        {

        }
        public Kvadrat(float a)
        {
            this.a = a;
            if (a <= 0)
            {
                throw new ArgumentException("Duljina stranice A ne može biti manja od 0");
            }
            
        }

        public override string IspisiPodatke()
        {
            return String.Format("Stranica a= {0}, povrsina = {1}", a, IzracunajPovrsinu());
        }

        public override float IzracunajPovrsinu()
        {
            float Povrsina = a * a;
            return Povrsina;
        }
    }
}
