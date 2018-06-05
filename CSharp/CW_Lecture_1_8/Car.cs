using System;

namespace CW_Lecture_1_8
{
    public class Car
    {
        public readonly int WheelsCount = 4;

        public string Brand;
        public string Model;
        public double EngineVolume;
        public DateTime ManufactureDate;


        public Car(string breand, double engineVolume)
        {
            Console.WriteLine($"Ctor with 2 params");

            Brand = breand;
            EngineVolume = engineVolume;
        }

        public Car(string brand, string model, double engineVolume, DateTime manufactureDate)
            :this(brand, engineVolume)
        {
            //Brand = brand;
            Model = model;
            //EngineVolume = engineVolume;
            ManufactureDate = manufactureDate;
        }
        
    }
}