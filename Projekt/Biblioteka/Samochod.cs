using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Samochod
    {
        public string Model { get; set; }
        public decimal Cena { get; set; }

        public Samochod(string model, decimal cena)
        {
            this.Model = model;
            Cena = cena;
        }
    }
}
