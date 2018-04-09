using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Roslina : Istota, IRosnace, IRoslinowate
    {
        public double IloscTlenu { get; set; }
        public StanRosliny Stan { get; set; }

       public enum StanRosliny
        {
            Rosnie,
            Zakwitla,
            Zaowocowala
        }
        public Roslina()
        {

        }

        void IRosnace.Rosnij()
        {
           Wysokosc = Wysokosc * (IloscTlenu/100);
        }

        public void Zakwitnij()
        {
            Stan = StanRosliny.Zakwitla;
        }

        public void Owocuj()
        {
            Stan = StanRosliny.Zaowocowala;
        }

        void IRoslinowate.Rosnij()
        {
            Stan = StanRosliny.Rosnie; 
        }
    }
}
