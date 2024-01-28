using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ConsoleUI
    {
        public void MenuDisplay()
        {
            Console.WriteLine("####################");
            Console.WriteLine("Baza Danych Pojazdów");
            Console.WriteLine("####################\n");
            Console.WriteLine("Jaką opcję chcesz wybrać?");
            Console.WriteLine("1. Dodaj pojazd do bazy danych.");
            Console.WriteLine("2. Usuń pojazd z bazy danych.");
            Console.WriteLine("3. Wyświetl pojazdy z bazy danych.");
            Console.WriteLine("4. Zaaktualizuj baze danych.");
            Console.WriteLine("5. Wyjdź");

        }

        public void AddVehicle()
        {
            Console.WriteLine("Podaj typ pojazdu jaki chcesz dodać");
            Console.WriteLine("1 - Pojazd osobowy");
            Console.WriteLine("2 - Motor");
        }

    }
}