using System;

namespace Constructor
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle()
        {
            System.Console.WriteLine("Vehicle is being initialized");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }
}
