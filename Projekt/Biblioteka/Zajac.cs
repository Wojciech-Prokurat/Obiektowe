using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Zajac : Zwierze, IRoslinozerne
    {
        public void ZjedzRosline()
        {
            Console.Out.WriteLine(Imie + " zjadł mleczyka");
        }

        public void ZnajdzPozywienie()
        {
            Console.Out.WriteLine(Imie + " znalazł mleczyka");
        }
    }
}
