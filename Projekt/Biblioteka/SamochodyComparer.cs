using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class SamochodyComparer : IComparer<Człowiek>
    {
        public int Compare(Człowiek pom, Człowiek pom2)
        {
            return pom.listaAut.Count.CompareTo(pom2.listaAut.Count);
        }
    }
}
