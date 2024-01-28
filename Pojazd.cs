using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Pojazd
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int RokProdukcji { get; set; }

        public DanePojazdu DanePojazdu { get; set; }
        public override string ToString()
        {
            return $"Marka: {Marka}, Model: {Model}, Rok Produkcji: {RokProdukcji}, Numer VIN: {DanePojazdu.NumerVin}, Przebieg: {DanePojazdu.Przebieg}, Rodzaj Paliwa: {DanePojazdu.RodzajPaliwa}, Napęd: {DanePojazdu.Naped}, Pojemność skokowa: {DanePojazdu.PojemnoscSkokowa}, ";
        }
    }
    
}
