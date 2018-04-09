using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{

    public class Hiena : Zwierze, IRoslinozerne, IMiesozerne
    {
        public void ZjedzMieso()
        {
            Console.Out.WriteLine(Imie + " zjadł węża");
        }

        public void ZjedzRosline()
        {
            Console.Out.WriteLine(Imie + " znalazł węża");
        }

        void IRoslinozerne.ZnajdzPozywienie()
        {
            Console.Out.WriteLine(Imie + " zjadł owoc kaktusa");
        }

        void IMiesozerne.ZnajdzPozywienie()
        {
            Console.Out.WriteLine(Imie + " znalazł owoc kaktusa");
        }
    }
}
