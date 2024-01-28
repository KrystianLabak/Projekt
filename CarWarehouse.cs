using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class CarWarehouse
    {
        public void AddCar()
        {
            Console.WriteLine("Podaj Marke");
            var marka = Console.ReadLine();
            Console.WriteLine("Podaj Model");
            var model = Console.ReadLine();
            Console.WriteLine("Podaj Rok Produkcji");
            var yearOfProduction = Console.ReadLine();
            Console.WriteLine("Podaj Numer VIN");
            var numVIN = Console.ReadLine();
            Console.WriteLine("Podaj Przebieg");
            var mileage = Console.ReadLine();
            Console.WriteLine("Podaj Rodzaj Paliwa");
            var fuelType = Console.ReadLine();
            Console.WriteLine("Podaj Napęd");
            var drivetrain = Console.ReadLine();
            Console.WriteLine("Podaj Pojemność skokową");
            var engineDisplacement = Console.ReadLine();
            Console.WriteLine("Podaj ilość drzwi");
            var doorAmount = Console.ReadLine();
            var osobowy = new Osobowy
            {
                Marka = marka,
                Model = model,
                RokProdukcji = int.Parse(yearOfProduction),
                DanePojazdu = new DanePojazdu
                {
                    NumerVin = numVIN,
                    PojemnoscSkokowa = engineDisplacement,
                    Przebieg = int.Parse(mileage),
                    RodzajPaliwa = fuelType,
                    Naped = drivetrain,
                },
                IloscDrzwi = int.Parse(doorAmount)
            };
            var addvehicle = new DataBaseReader();
            addvehicle.AddVehicle(osobowy);
            Console.WriteLine("Samochód osobowy został dodany do bazy danych.");
        }
        public void AddMotor()
        {
            Console.WriteLine("Podaj Marke");
            var markaMotor = Console.ReadLine();
            Console.WriteLine("Podaj Model");
            var modelMotor = Console.ReadLine();
            Console.WriteLine("Podaj Rok Produkcji");
            var yearOfProductionMotor = Console.ReadLine();
            Console.WriteLine("Podaj Numer VIN");
            var MotorNumVIN = Console.ReadLine();
            Console.WriteLine("Podaj Przebieg");
            var mileageMotor = Console.ReadLine();
            Console.WriteLine("Podaj Rodzaj Paliwa");
            var fuelTypeMotor = Console.ReadLine();
            Console.WriteLine("Podaj Napęd");
            var drivetrainMotor = Console.ReadLine();
            Console.WriteLine("Podaj Pojemność skokową");
            var engineDisplacementMotor = Console.ReadLine();
            Console.WriteLine("Podaj typ Silnika");
            var engineType = Console.ReadLine();
            var motor = new Motor
            {
                Marka = markaMotor,
                Model = modelMotor,
                RokProdukcji = int.Parse(yearOfProductionMotor),
                DanePojazdu = new DanePojazdu
                {
                    NumerVin = MotorNumVIN,
                    PojemnoscSkokowa = engineDisplacementMotor,
                    Przebieg = int.Parse(mileageMotor),
                    RodzajPaliwa = fuelTypeMotor,
                    Naped = drivetrainMotor,
                },
                TypSilnika = engineType
            };
            var addmotor = new DataBaseReader();
            addmotor.AddVehicle(motor);
            Console.WriteLine("Motor został dodany do bazy danych.");
        }
        public void RemoveVehicle()
        {
            var database = new DataBaseReader();
            var pojazdy = database.VehicleDB();
            for (var i = 0; i < pojazdy.Count; i++)
            {
                Console.WriteLine($"{i + 1},{pojazdy[i]}");
            }
            Console.WriteLine("Który pojazd chcesz usunąć? (Podaj index)");
            var index = int.Parse(Console.ReadLine());
            var pojazdDoUsuniecia = pojazdy[index - 1];
            database.RemoveVehicle(pojazdDoUsuniecia);
            Console.WriteLine("Pojazd został usunięty.");
        }
        public void UpdateVehicle()
        {
            var database = new DataBaseReader();
            var pojazdy = database.VehicleDB();
            for (var i = 0; i < pojazdy.Count; i++)
            {
                Console.WriteLine($"{i + 1},{pojazdy[i]}");
            }
            Console.WriteLine("Który pojazd chcesz zaaktualizować? (Podaj index)");
            var index = int.Parse(Console.ReadLine());
            var pojazdDoUsuniecia = pojazdy[index - 1];
            Console.WriteLine("Podaj Marke");
            var marka = Console.ReadLine();
            Console.WriteLine("Podaj Model");
            var model = Console.ReadLine();
            Console.WriteLine("Podaj Rok Produkcji");
            var yearOfProduction = Console.ReadLine();
            Console.WriteLine("Podaj Numer VIN");
            var NumVIN = Console.ReadLine();
            Console.WriteLine("Podaj Przebieg");
            var mileage = Console.ReadLine();
            Console.WriteLine("Podaj Rodzaj Paliwa");
            var fuelType = Console.ReadLine();
            Console.WriteLine("Podaj Napęd");
            var drivetrain = Console.ReadLine();
            Console.WriteLine("Podaj Pojemność skokową");
            var engineDisplacement = Console.ReadLine();
            Pojazd pojazdDoAktualizacji;
            if (pojazdDoUsuniecia.GetType() == typeof(Motor))
            {
                Console.WriteLine("Podaj typ silnika");
                var typSilnika = Console.ReadLine();
                pojazdDoAktualizacji = new Motor
                {
                    Marka = marka,
                    Model = model,
                    RokProdukcji = int.Parse(yearOfProduction),
                    DanePojazdu = new DanePojazdu
                    {
                        NumerVin = NumVIN,
                        PojemnoscSkokowa = engineDisplacement,
                        Przebieg = int.Parse(mileage),
                        RodzajPaliwa = fuelType,
                        Naped = drivetrain,
                    },
                    TypSilnika = typSilnika
                };
                database.UpdateDataBase(pojazdDoUsuniecia, pojazdDoAktualizacji);
            }
            else if (pojazdDoUsuniecia.GetType() == typeof(Osobowy))
            {
                Console.WriteLine("Podaj ilość drzwi");
                var iloscDrzwi = Console.ReadLine();
                pojazdDoAktualizacji = new Osobowy
                {
                    Marka = marka,
                    Model = model,
                    RokProdukcji = int.Parse(yearOfProduction),
                    DanePojazdu = new DanePojazdu
                    {
                        NumerVin = NumVIN,
                        PojemnoscSkokowa = engineDisplacement,
                        Przebieg = int.Parse(mileage),
                        RodzajPaliwa = fuelType,
                        Naped = drivetrain,
                    },
                    IloscDrzwi = int.Parse(iloscDrzwi)
                };
                database.UpdateDataBase(pojazdDoUsuniecia, pojazdDoAktualizacji);
            }
            Console.WriteLine("Pojazd został zaaktualizowany.");
        }

        internal void VehicleDisplay()
        {
            DataBaseReader db = new DataBaseReader();
            foreach (var cert in db.VehicleDB())
            {
                Console.WriteLine(cert);
            }
        }
    }
}
