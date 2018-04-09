using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Dom
    {
        public double Powierzchnia { get; set; }
        public decimal Cena { get; set; }

        public Dom(double p, decimal c)
        {
            Powierzchnia = p;
            Cena = c;
        }
    }
}
