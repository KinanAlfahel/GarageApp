using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    public interface IVehicle
    {
        public void ShowV();

        public string RegNr { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

    }
}
