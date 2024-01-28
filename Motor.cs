using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Motor : Pojazd
    {
        public string TypSilnika { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()},Typ Silnika: {TypSilnika}";
        }
    }
}
