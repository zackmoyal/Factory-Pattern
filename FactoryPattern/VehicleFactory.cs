using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        // method to get vehicle based on the number of tires
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                // if input is 2 (tires), return motorcycle
                case 2:
                    return new Motorcycle();
                // if input is 4 (tires), return motorcycle
                case 4:
                    return new Car();
                // error handling for any integer input that is not 2 or 4
                default:
                    throw new ArgumentException("Invalid number of tires. Cannot determine vehicle type.");
            }
        }
    }
}
