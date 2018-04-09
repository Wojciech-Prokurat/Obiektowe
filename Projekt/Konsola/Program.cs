using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;

namespace Konsola
{
    class Program
    {
       static List<Istota> istoty = new List<Istota>();
        static List<IMiesozerne> miesozerne = new List<IMiesozerne>();
        static List<IRoslinozerne> roslinozerne = new List<IRoslinozerne>();
        static void Main(string[] args)
        {
            DodajIstotki();
            PrzepiszMiesozerne();
            PrzepiszRoslinozerne();
            Nakarm();
            List<Człowiek> ludzie = new List<Człowiek>();

            Człowiek marcin = new Człowiek();
            marcin.Imie = "Marcin";
            marcin.Iq = 195;
            marcin.Szybkosc = 30;
            marcin.Wysokosc = 150;
            marcin.listaAut = new List<Samochod>{
                new Samochod("Citroen",1000),
                new Samochod("Scoda", 500),
                new Samochod("Yeti",800)};
            marcin.listaDomow = new List<Dom>
            {
                new Dom(21, 2000)
            };
            //-------------------
            Człowiek marcin2 = new Człowiek();
            marcin2.Imie = "Marcin2";
            marcin2.Iq = 200;
            marcin2.Szybkosc = 40;
            marcin2.Wysokosc = 160;
            marcin2.listaAut = new List<Samochod>{
                new Samochod("Citroen",1000),
                new Samochod("Yeti",800)};
            marcin2.listaDomow = new List<Dom>
            {
                new Dom(51, 2100),
                new Dom(21, 2000)
            };
            //-------------------
            Człowiek marcin3 = new Człowiek();
            marcin3.Imie = "Marcin3";
            marcin3.Iq = 190;
            marcin3.Szybkosc = 20;
            marcin3.Wysokosc = 170;
            marcin3.listaAut = new List<Samochod>{
                
                new Samochod("Yeti",800)};
            marcin3.listaDomow = new List<Dom>
            {
                new Dom(51, 2100),
                new Dom(111, 3000),
                new Dom(21, 2000)
            };

            ludzie.Add(marcin);
            ludzie.Add(marcin2);
            ludzie.Add(marcin3);
            Console.Out.WriteLine("Bez sortu");
            foreach (Człowiek c in ludzie)
            {
                Console.Out.WriteLine(c.Imie);
            }
            ludzie.Sort(Człowiek.SortByCarCount);
            Console.Out.WriteLine("Bez po autach");
            foreach (Człowiek c in ludzie)
            {
                Console.Out.WriteLine(c.Imie);
            }
            ludzie.Sort(Człowiek.SortByCarCount);
            Console.Out.WriteLine("Bez po domach");
            foreach (Człowiek c in ludzie)
            {
                Console.Out.WriteLine(c.Imie);
            }
            ludzie.Sort(Człowiek.SortBySumaCount);
            Console.Out.WriteLine("Bez po sumie");
            foreach (Człowiek c in ludzie)
            {
                Console.Out.WriteLine(c.Imie);
            }
            Console.In.ReadLine();

        }
        public void Wypisz()
        {
            
        }
        static void DodajIstotki()
        {
            Wilk wilk = new Wilk();
            wilk.Imie = "wilczek Witold";
            wilk.Wysokosc = 120;
            wilk.Szybkosc = 60;

            Zajac zajac = new Zajac();
            zajac.Imie = "zajac Zenek";
            zajac.Wysokosc = 30;
            zajac.Szybkosc = 50;

            Hiena hiena = new Hiena();
            hiena.Imie = "hiena Heniek";
            hiena.Wysokosc = 150;
            hiena.Szybkosc = 70;

            istoty.Add(wilk);
            istoty.Add(zajac);
            istoty.Add(hiena);
        }

        static void PrzepiszRoslinozerne()
        {
            foreach(Istota istota in istoty)
            {
                if(istota is IRoslinozerne)
                {
                    roslinozerne.Add((IRoslinozerne)istota);
                }
            }
        }
        static void PrzepiszMiesozerne()
        {
            foreach (Istota istota in istoty)
            {
                if (istota is IMiesozerne)
                {
                    miesozerne.Add((IMiesozerne)istota);
                }
            }
        }

        static void Nakarm()
        {
            foreach (IRoslinozerne istota in roslinozerne)
            {
                istota.ZnajdzPozywienie();
                istota.ZjedzRosline();
            }
            foreach (IMiesozerne istota in miesozerne)
            {
                istota.ZnajdzPozywienie();
                istota.ZjedzMieso();
            }
        }

        static void NakarmMieskiem(IMiesozerne istota)
        {
            istota.ZnajdzPozywienie();
            istota.ZjedzMieso();
        }

        static void NakarmRoslina(IRoslinozerne istota)
        {
            istota.ZnajdzPozywienie();
            istota.ZjedzRosline();
        }


    }
}
