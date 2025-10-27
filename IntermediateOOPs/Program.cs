using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateOOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Brand = "Ford",
                Model = "Mastang",
                MaxSpeed = 100,
                Price = 1000000
            };

            // Addiing this line to resolve comment of pr
            Console.WriteLine($"Branch: {car.Brand}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Max Speed: {car.MaxSpeed}");
            Console.WriteLine($"Branch: {car.Brand}");
            Console.WriteLine($"Number of wheels: {Car.NumberOfWheels}");
        }
    }
}
