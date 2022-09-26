using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            CarLot carLot = new CarLot();
            
            Car firstCar = new Car();
            firstCar.Year = 2004;
            firstCar.Make = "Volkswagen";
            firstCar.Model = "Beetle";
            firstCar.EngineNoise = "Brrrrrr";
            firstCar.HonkNoise = "Beepbeep!";
            carLot.CarToList = firstCar;

            Car secondCar = new Car()
            {
                Year = 2008,
                Make = "Honda",
                Model = "Accord",
                EngineNoise = "Hmmmmmmm"
            };
            carLot.CarToList = secondCar;

            Car thirdCar = new Car (1908, "Ford", "Model T");
            thirdCar.IsDriveable = false;
            carLot.CarToList = thirdCar;

            Car fourthCar = new Car (2011, "Hyundai", "Sonata", "vrooom", "beep");
            Car fifthCar = new Car (2005, "Honda", "Civic", "vrooom", "beep");
            Car sixthCar = new Car(2013, "Jeep", "Wrangler", "brrrr", "beeep");

            firstCar.MakeEngineNoise();
            firstCar.MakeHonkNoise();
            Console.WriteLine();

            secondCar.MakeEngineNoise();
            secondCar.MakeHonkNoise();
            Console.WriteLine();

            thirdCar.MakeEngineNoise();
            thirdCar.MakeHonkNoise();

            Console.WriteLine("\n");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLot.DescribeCars();

            if (CarLot.numberOfCars == 1) Console.WriteLine($"\n There is {CarLot.numberOfCars} car in the car lot.");
            else Console.WriteLine($"\nThere are {CarLot.numberOfCars} cars in the car lot.");
        }
    }
}
