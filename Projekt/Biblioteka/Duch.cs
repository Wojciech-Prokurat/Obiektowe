using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Duch : Istota
    {
        private int przezroczystosc;
        public int IloscEktoplazmy { get; set; }
        public string MetodaStraszenia { get; set; }

        public int Przezroczystosc
        {
            get { return przezroczystosc; }
            set { if (value < 100 && value > 0) przezroczystosc = value;
                else throw new PrzezroczystoscException();
            }
        }

        public Duch()
        {

        }

    }
}
