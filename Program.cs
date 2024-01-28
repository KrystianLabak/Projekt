using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Projekt
{
    class Program
    {
        static void Main()
        {
            var menu = new ConsoleUI();
            var controller = new CarWarehouse();
            int option;
            do
            {
                menu.MenuDisplay();
                var isCorrect = int.TryParse(Console.ReadLine(), out option);
                if (!isCorrect) option = 0;
                switch (option)
                {
                    case 1:
                        menu.AddVehicle();
                        int option2 = Convert.ToInt32(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                controller.AddCar();
                                break;
                            case 2:
                                controller.AddMotor();
                                break;
                            default:
                                Console.WriteLine("Podano zły parametr");
                                break;
                        }
                        break;
                    case 2:
                        controller.RemoveVehicle();

                        break;
                    case 3:
                        controller.VehicleDisplay();
                        break;
                    case 4:
                        controller.UpdateVehicle();
                        break;
                    case 5:
                        Console.WriteLine("Do zobaczenia następnym razem!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Podano złą liczbę");
                        break;
                }
                Console.WriteLine("Kliknij by, kontynuować");
                Console.ReadKey();
                Console.Clear();
            } while (option != 5);
        }
    }
}