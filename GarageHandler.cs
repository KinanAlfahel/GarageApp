using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class GarageHandler
    {

        public Garage<IVehicle> garage;

        public GarageHandler(int size)
        {
            garage = new Garage<IVehicle>(size);
        }

        public void PrintAllVehicles()
        {
            foreach (var vehicle in garage)
            {
                //add next attiribute according to car type or regno first 3 strings

                //if (vehicle.RegNr == ("AIR" + ))
                //{

                //}
                Console.WriteLine($"Reg No: {vehicle.RegNr} - Color: {vehicle.Color} - Number of Wheels: {vehicle.NumberOfWheels} ");
            }
        }

        public void SeedVehicles()
        {
            garage.AddVehicle(new Airplane("AIR111", "White", 6, 2));
            garage.AddVehicle(new Airplane("AIR222", "White", 6, 2));
            garage.AddVehicle(new Airplane("AIR333", "White", 6, 2));
            garage.AddVehicle(new Motorcycle("MTR444", "red", 2, 2));
            garage.AddVehicle(new Motorcycle("MTR555", "black", 2, 4));
            garage.AddVehicle(new Motorcycle("MTR333", "black", 3, 6));
            garage.AddVehicle(new Car("CAR444", "White", 4, "Gasoline"));
            garage.AddVehicle(new Car("CAR555", "black", 4, "Gasoline"));
            garage.AddVehicle(new Car("CAR333", "red", 4, "Diesel"));
            garage.AddVehicle(new Bus("BUS444", "White", 6, 50));
            garage.AddVehicle(new Bus("BUS555", "blue", 8, 50));
            garage.AddVehicle(new Boat("BOT444", "White", 1, 50));
            garage.AddVehicle(new Boat("BOT555", "black", 1, 70));
            garage.AddVehicle(new Boat("BOT333", "red", 1, 70));
        }

        private string regno;
        private string color;
        private int numofweel;

        public void Park()
        {

            Console.WriteLine("Airplain         1");
            Console.WriteLine("Car              2");
            Console.WriteLine("Bus              3");
            Console.WriteLine("Motorcycle       4");
            Console.WriteLine("Boat             5");
            Console.WriteLine("Exit             0");
            Console.WriteLine("===================");
            Console.WriteLine("                ");
            Console.WriteLine("Please select your vehicle type number: ");


            switch (Console.ReadLine())
            {
                case "1":
                    //string v = Subpark("", "", "", "");
                    AirplainSelection();
                    break;
                case "2":
                    CarSelection();
                    break;
                case "3":
                    BusSelection();
                    break;
                case "4":
                    MotorcycleSelection();
                    break;
                case "5":
                    BoatSelection();
                    break;
                case "0":
                    Console.WriteLine("Good Bye and Hava a Nice Day! ");
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("You entered invalid value, please enter a number!");
                    Park();
                    break;
            }

            // ta emot eller skapa ett fordon
            // garage.AddVehicle(kasta in det nya fordonet här)
        }


        private void BoatSelection()
        {
            Console.WriteLine("Please enter vehicle's Registration Number:");


            if (garage.Where(IVehicle => regno == IVehicle.RegNr).Count() == 0)
            {
                regno = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Registration number is used, enter valid number: ");
                BoatSelection();
            }

            Console.WriteLine(" ");
            Console.WriteLine("Please enter color:");
            color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter number of wheels:");
            int numofweel;
            string num2 = Console.ReadLine();
            while (!int.TryParse(num2, out numofweel))
            {
                Console.WriteLine("Enter valid number!");
                num2 = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Please enter Boat Length:");
            string num = Console.ReadLine();
            int length;
            while (!int.TryParse(num, out length))
            {
                Console.WriteLine("Enter valid number!");
                num = Console.ReadLine();
            }

            garage.AddVehicle(new Airplane(regno, color, numofweel, length));
            Console.WriteLine($"Reg No: {regno} - Color: {color} - Number of Wheels: {numofweel} - Number of Wheels: {length} ");

        }

        private void BusSelection()
        {
            Console.WriteLine("Please enter vehicle's Registration Number:");
            regno = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter color:");
            color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter number of wheels:");
            string num2 = Console.ReadLine();
            while (!int.TryParse(num2, out numofweel))
            {
                Console.WriteLine("Enter valid number!");
                num2 = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Please enter numberOfSeats");
            string num = Console.ReadLine();
            int numberOfSeats;
            while (!int.TryParse(num, out numberOfSeats))
            {
                Console.WriteLine("Enter valid number!");
                num = Console.ReadLine();
            }

            garage.AddVehicle(new Bus(regno, color, numofweel, numberOfSeats));
            Console.WriteLine($"Reg No: {regno} - Color: {color} - Number of Wheels: {numofweel} - Number of Wheels: {numberOfSeats} ");

        }

        private void CarSelection()
        {
            Console.WriteLine("Please enter vehicle's Registration Number:");
            regno = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter color:");
            color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter numberofwheels:");
            int numofweel;
            string num2 = Console.ReadLine();
            while (!int.TryParse(num2, out numofweel))
            {
                Console.WriteLine("Enter valid number!");
                num2 = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Please enter Fuel Type:");
            string fueltype = Console.ReadLine();

            garage.AddVehicle(new Car(regno, color, numofweel, fueltype));
            Console.WriteLine($"Reg No: {regno} - Color: {color} - Number of Wheels: {numofweel} - Number of Wheels: {fueltype} ");

        }

        private void MotorcycleSelection()
        {
            Console.WriteLine("Please enter vehicle's Registration Number:");
            regno = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter color:");
            color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter numberofwheels:");
            int numofweel;
            string num2 = Console.ReadLine();
            while (!int.TryParse(num2, out numofweel))
            {
                Console.WriteLine("Enter valid number!");
                num2 = Console.ReadLine();
            }
            Console.WriteLine("");

            Console.WriteLine("Please enter cylinder Vol:");
            double cylinderVol;
            string num = Console.ReadLine();
            while (!double.TryParse(num, out cylinderVol))
            {
                Console.WriteLine("Enter valid number!");
                num = Console.ReadLine();
            }

            garage.AddVehicle(new Motorcycle(regno, color, numofweel, cylinderVol));
            Console.WriteLine($"Reg No: {regno} - Color: {color} - Number of Wheels: {numofweel} - Number of Wheels: {cylinderVol} ");


        }

        private void AirplainSelection()
        {
            Console.WriteLine("Please enter vehicle's Registration Number:");
            regno = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter color:");
            color = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter numberofwheels:");
            string num = Console.ReadLine();
            int numofweel;
            while (!int.TryParse(num, out numofweel))
            {
                Console.WriteLine("Enter valid number!");
                num = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Please enter numberofEngines:");
            string num2 = Console.ReadLine();
            int numofengines;
            while (!int.TryParse(num2, out numofengines))
            {
                Console.WriteLine("Enter valid number!");
                num = Console.ReadLine();
            }
            Console.WriteLine("");

            garage.AddVehicle(new Boat(regno, color, numofweel, numofengines));
            Console.WriteLine($"Reg No: {regno} - Color: {color} - Number of Wheels: {numofweel} - Number of Wheels: {numofengines} ");


        }

        public void Unpark()
        {
            Console.WriteLine("Please enter Registration number of the vehicle:");
            regno = Console.ReadLine();
            garage.RemoveVehicle(regno);
        }


    }
}
