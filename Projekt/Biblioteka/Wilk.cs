using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Wilk : Zwierze, IMiesozerne
    {
        public void ZjedzMieso()
        {
            Console.Out.WriteLine(Imie + " zjadł króliczka");
        }

        public void ZnajdzPozywienie()
        {
            Console.Out.WriteLine(Imie + " znalazł króliczka");
        }
    }
}
