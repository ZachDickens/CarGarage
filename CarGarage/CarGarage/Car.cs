using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Model { get; private set; }
        public string Make { get; private set; }
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public bool CarStarted { get; private set; } 

        public Car()
        {
            Speed = 0;
            GasLevel = 100;
            CarStarted = false;
        }

        public Car(int startingGasLevel)
        {
            Speed = 0;
            GasLevel = startingGasLevel;
            CarStarted = false;
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Speed = 0;
            GasLevel = 100;
            CarStarted = false;
        }

        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 10;
        } 
        public void AddFuel()
        {
            GasLevel = 100;
        }
        public void Brake()
        {
            Speed -= 10;
            if (Speed < 0)
            {
                Speed = 0;
            }
        }
        public void ToggleEngine()
        {
            CarStarted = !CarStarted;
            Speed = 0;
            if(CarStarted) 
            {
                Console.WriteLine("Your car is running");

            }
            else
            {
                Console.WriteLine("Your car is off");
            }
        }

    }
}
