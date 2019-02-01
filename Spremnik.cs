using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Spremnik
    {
       private List<Cetverokut> cetverokuts = new List<Cetverokut>();
        public void DodajCetverokut(Cetverokut C)
        {
            cetverokuts.Add(C);
        }
        public float PovrsinaSvihCetverokuta()
        {
            float SumaPovrsina = 0;
            foreach(Cetverokut C in cetverokuts)
            {
                SumaPovrsina += C.IzracunajPovrsinu();
            }
            return SumaPovrsina;
        }
    }
}
