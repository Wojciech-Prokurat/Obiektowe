using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class DomyComparer : IComparer<Człowiek>
    {
        public int Compare(Człowiek x, Człowiek y)
        {
            return x.listaDomow.Count.CompareTo(y.listaDomow.Count);
        }
    }
}
