namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // enter the number of tires for the vehicle, try parsing the input to an integer,
            // and store the result in the numberOfTires variable.
            // if successful, continue with Drive() method, else, proceed to error handling.
            Console.WriteLine("Enter the number of tires for the vehicle:");
            if (int.TryParse(Console.ReadLine(), out int numberOfTires))
            {
                try
                {
                    // get the vehicle from VehicleFactory based on the number of tires
                    IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
                    // drive the vehicle
                    vehicle.Drive();
                }
                catch (ArgumentException ex) 
                {
                    // handle exceptions for invalid input
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                // error handling for any input that isn't an integer
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
