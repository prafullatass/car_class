using System;
using System.Collections.Generic;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
           Car Corolla = new Car() {
               Make = "Toyota",
               Model = "Corolla",
               Year = 2019,
               Price = 21000.99
           };
           Corolla.Drive("vrooom");
            Car CR_V = new Car();
            CR_V.Model = "Honda";
            CR_V.Model = "CR-V";
            CR_V.Year =2014;
            CR_V.Price= 27999.99;

            CR_V.Drive();
            List<Car> CarLot = new List<Car>();
            CarLot.Add(Corolla);
            CarLot.Add(CR_V);

            foreach (Car car in CarLot)
            {
                Console.WriteLine($@"
                Make : {car.Make}
                Model : {car.Model}
                Year : {car.Year}
                Price : {car.Price}
                ");
            }
        }
    }
}
