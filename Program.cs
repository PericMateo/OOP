using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cetverokut C1 = new Pravokutnik(2, 4);
            Cetverokut P1 = new Kvadrat(5);
            Cetverokut K1 = new Pravokutnik(3, 4);
            Console.WriteLine(C1.IspisiPodatke());
            Console.WriteLine(P1.IspisiPodatke());
            Spremnik S1 = new Spremnik();
            S1.DodajCetverokut(C1);
            S1.DodajCetverokut(P1);
            S1.DodajCetverokut(K1);
            Console.WriteLine("Suma svih povrsina= {0}", S1.PovrsinaSvihCetverokuta());
        }
    }
}
	
