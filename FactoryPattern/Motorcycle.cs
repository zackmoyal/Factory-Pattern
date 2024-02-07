using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // implement Motorcycle class conforming to IVehicle interface
    public class Motorcycle : IVehicle
    {
        // Drive method implementation for Motorcycle
        public void Drive()
        {
            Console.WriteLine("Riding a motorcycle!");
        }
    }
}
