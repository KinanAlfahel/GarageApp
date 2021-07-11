using System;
using static GarageApp.Vehicle;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //make the size user defined not fixed
            //or make error or notification says garage is full
            

            var gh = new GarageHandler(20);
            
            Console.WriteLine("Welcome to parking service!");
            Console.WriteLine("Please select your service type number ");
            Console.WriteLine("To park a vehicle                        1");
            Console.WriteLine("To unpark a vehicle                      2");
            Console.WriteLine("To show all vehicles in the garage       3");           
            Console.WriteLine("Exit             0");
            Console.WriteLine("===================");
            Console.WriteLine("                ");

            switch (Console.ReadLine())
            {
                case "1":
                    //string v = Subpark("", "", "", "");
                    gh.Park();
                    break;
                case "2":
                    gh.Unpark();
                    break;
                case "3":
                    gh.PrintAllVehicles();
                    break;

                case "0":
                    Console.WriteLine("Good Bye and Hava a Nice Day! ");
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("You entered invalid value, please enter a number!");
                    break;
            }


        }
    }
}
