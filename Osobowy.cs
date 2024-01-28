using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Osobowy : Pojazd
    {
        public int IloscDrzwi { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()},Ilość drzwi: {IloscDrzwi}";
        }
    }
}
