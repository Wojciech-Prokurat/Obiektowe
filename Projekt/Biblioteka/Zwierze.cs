using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Zwierze : Istota, IRosnace, ICloneable
    {
        private int szybkosc;

        public int Szybkosc
        {
            get { return szybkosc; }
            set { if (value < 330) szybkosc = value;
                else
                {
                    throw new SzybkoscException();
                }
            }
        }
        
        public Zwierze()
        {

        }

        public void Rosnij()
        {
           Wysokosc += Wysokosc*0.2;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
