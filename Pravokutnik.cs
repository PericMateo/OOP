using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Pravokutnik:Cetverokut
    {
        private float a;
        private float b;

        private Pravokutnik()
        {

        }
        public Pravokutnik(float a, float b)
        {
            this.a = a;
            this.b = b;
            if (this.a <= 0)
            {
                throw new ArgumentException(" Duljina stranice A ne može biti manja od 0 ");
            }
            else if (this.b <= 0)
            {
                throw new ArgumentException("Duljina stranice B ne može biti manja od 0");
            }
            
               
        }
        public override string IspisiPodatke()
        {
            return String.Format( "Stranica a={0}, stranica b={1}, povrsina={2}",a,b,IzracunajPovrsinu());
            
        }

        public override float IzracunajPovrsinu()
        {
            float Povrsina = a * b;
            return Povrsina;
            
        }
    }
}
