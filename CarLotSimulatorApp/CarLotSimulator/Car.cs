using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    using System;

    public class Car
    {
        public Car()
        {
        }
        public Car(int year, string make, string model, string engineNoise = "pocketa-pocketa", string honkNoise = "BLARRRRRRR D:", bool isDriveable = true)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; } = "pocketa-pocketa";
        public string HonkNoise { get; set; } = "BEEEEP!";
        public bool IsDriveable { get; set; } = true;

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The {Year} {Make} {Model}'s engine makes a sound: {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"The {Model} honks its horn. {HonkNoise}");
        }
    }
}
