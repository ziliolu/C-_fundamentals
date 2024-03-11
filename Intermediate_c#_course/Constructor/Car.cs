using System;

namespace Constructor
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initialized as {0}", registrationNumber);          
        }
    }
}
