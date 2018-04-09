using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Człowiek : Zwierze, IEnumerable, IComparable
    {
        public int Iq { get; set; }
        public List<Dom> listaDomow { get; set; }
        public List<Samochod> listaAut { get; set; }
        public static IComparer<Człowiek> SortByCarCount { get { return (IComparer<Człowiek>)new SamochodyComparer(); } }
        public static IComparer<Człowiek> SortByDomCount { get { return (IComparer<Człowiek>)new DomyComparer(); } }
        public static IComparer<Człowiek> SortBySumaCount { get { return (IComparer<Człowiek>)new SumaComparer(); } }

        public Człowiek()
        {

        }



        public IEnumerator GetEnumerator()
        {
           return listaAut.GetEnumerator();
        }

        public IEnumerable GetDomy(decimal cena = 0)
        {
            foreach(Dom d in listaDomow)
            {
                if(d.Cena > cena)
                {
                    yield return d;
                }
            }
        }

        public int CompareTo(object obj)
        {
            Człowiek pom = (Człowiek)obj;
            return this.Iq.CompareTo(pom.Iq);
        }
    }
}
