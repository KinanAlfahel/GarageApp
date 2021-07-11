using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    public abstract class Vehicle: IVehicle
    {
   
        public string RegNr { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }


        public Vehicle(string regnr, string color, int numberofwheels)
        {
            RegNr = regnr;
            Color = color;
            NumberOfWheels = numberofwheels;
        }
        public void ShowV()
        {
            throw new NotImplementedException();
        }





        //registreringsnummer, färg, antal hjul och andra egenskaper

        //        Registreringsnumret är unikt
        //● Det måste minst finnas följande subklasser:
        //○ Airplane
        //○ Motorcycle
        //○ Car
        //○ Bus
        //○ Boat

        //        Number of Engines
        //○ Cylinder volume
        //○ Number of seats
        //○ Lenght

        

        


    }

    public class Airplane : Vehicle
    {


        public int NumOfEngins { get; set; }

        public Airplane(string regnr, string color, int numberofwheels, int numOfEngins) : base(regnr, color, numberofwheels)
        {
            NumOfEngins = numOfEngins;
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(string regnr, string color, int numberofwheels, double cylinderVol) : base(regnr, color, numberofwheels)
        {
            CylinderVol = cylinderVol;
        }

        public double CylinderVol { get; set; }
        
    }
    public class Car : Vehicle
    {
        public Car(string regnr, string color, int numberofwheels, string fueltype) : base(regnr, color, numberofwheels)
        {
            Fueltype = fueltype;
        }

        public string Fueltype { get; set; }

        //○ Fueltype(Gasoline/Diesel)

    }

    public class Bus : Vehicle
    {
        public Bus(string regnr, string color, int numberofwheels, int numberOfSeats) : base(regnr, color, numberofwheels)
        {
            NumberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats { get; set; }

    }
    public class Boat : Vehicle
    {
        public Boat(string regnr, string color, int numberofwheels, int lenght) : base(regnr, color, numberofwheels)
        {
            Lenght = lenght;
        }

        public double Lenght { get; set; }
    }
}
