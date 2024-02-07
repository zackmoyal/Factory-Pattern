using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // implement Car class conforming to IVehicle interface
    public class Car : IVehicle
    {
        // Drive method implementation for Car
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }
}
