using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageApp.Vehicle;

namespace GarageApp
{
    class Garage<T> : IEnumerable<T> where T : IVehicle
    {

        private T[] vehicles;

        public Garage(int size)
        {
            vehicles = new T[size];
        }

        public bool AddVehicle(T v)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = v;
                    return true;
                }
            }
            return false;
        }


        public bool RemoveVehicle(string regno)
        {

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].RegNr == regno)
                {
                    vehicles[i] = default (T);
                    return true;
                }
            }

            return false;
        }


        //if (vehicles[i] = regNr)
        //       {
        //           vehicles[i] = (default T);
        //           return true;
        //       }



        //return false;


        //iterera över vehicles
        // om vehicles[i].RegNr == regNr
        // vehicles[i] == (default T)


        //return false;



        public IEnumerator<T> GetEnumerator()
        {
            foreach (var v in vehicles)
            {
                if (v != null)
                {
                    yield return v;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
