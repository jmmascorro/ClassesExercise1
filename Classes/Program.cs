using System;
using System.Collections.Generic;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            var suv = new Car();
            suv.Make = "Ford";
            suv.Model = "Escape";
            suv.Year = 2018;

            var truck = new Car();
            truck.Make = "Chevrolet";
            truck.Model = "Silverado";
            truck.Year = 2004;

            var cars = new List<Car>();
            cars.Add(truck);
            cars.Add(suv);

            Console.WriteLine("Make        Model      Year");
            Console.WriteLine("-------------------------");
            foreach (var car in cars)
            {
                
                Console.WriteLine($"{car.Make}  {car.Model}  {car.Year}");
            }
            
           





        }
    }
}
