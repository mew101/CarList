using System;
using System.Collections.Generic;

namespace ArrraysListsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var fordFiesta = new Car("Ford", "Fiesta", 2013);
            var subaruLegacy = new Car("Subaru", "Legacy", 2017);
            var hondaCrv = new Car("Honda", "CRV", 2014);

            var parkedCars = new Car[5];
            Console.WriteLine(parkedCars.Length);

            parkedCars[0] = hondaCrv;

            var firstCar = parkedCars[0];
            Console.WriteLine(firstCar.Make);

            var luxuryCars = new List<Car>();

            luxuryCars[0] = hondaCrv;
            luxuryCars.Add(firstCar);

            var firstLuxuryCar = luxuryCars[0];
        
                
            Console.ReadLine();
        }
    }
}
