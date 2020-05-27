using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car adamsCar = new Car(2010, 60_000);

            adamsCar.Make = "Mazda";
            adamsCar.Model = "3";
            adamsCar.Color = "Silver";

            Car drewsCar = new Car(2013, 70_000)
            {
                Make = "Audi",
                Model = "A6",
                Color = "Black",
            };
        }
    }
}