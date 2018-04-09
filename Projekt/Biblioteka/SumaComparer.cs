using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class SumaComparer : IComparer<Człowiek>
    {
        public int Compare(Człowiek pom, Człowiek pom2)
        {
            decimal suma1 = 0;
            decimal suma2 = 0;
            foreach (Samochod s in pom)
            {
                suma1 += s.Cena;
            }
            foreach (Dom d in pom.GetDomy())
            {
                suma1 += d.Cena;
            }

            foreach (Samochod s2 in pom2)
            {
                suma2 += s2.Cena;
            }
            foreach (Dom d2 in pom2.GetDomy())
            {
                suma2 += d2.Cena;
            }
            return suma1.CompareTo(suma2);
        }
    }
}
