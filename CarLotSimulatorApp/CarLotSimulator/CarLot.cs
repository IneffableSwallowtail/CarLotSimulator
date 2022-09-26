using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Cars = new List<Car>();
        public static int numberOfCars = 0;

        private Car car;

        public Car CarToList
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
                Cars.Add(car);
            }
        }
        
        public void DescribeCars()
        {
            foreach (Car auto in Cars)
            {
                Console.Write($"There is a {auto.Year} {auto.Make} {auto.Model} in the car lot. ");
                if (auto.IsDriveable == true) Console.WriteLine($" The {auto.Model} is driveable.\n");
                else Console.WriteLine($"the {auto.Model} is not driveable.\n");
            }
        }
    }
}
