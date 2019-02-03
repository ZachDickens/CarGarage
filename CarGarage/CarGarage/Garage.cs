using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> TheGarage { get; set; } 
        
        public void AddCar(string make,string model)
        {
            TheGarage.Add(new Car(make,model));
            
        }

        public Garage()
        {
            TheGarage = new List<Car>();
        }

        public void RemoveCar(int index)
        {
            TheGarage.RemoveAt(index);
        }

        public void ListAllCars()
        {
            for (int i = 0; i < TheGarage.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}",i.ToString(), TheGarage[i].Make, TheGarage[i].Model, TheGarage[i].GasLevel.ToString());
            }
        }
        public void Printfirstitem()
        {
            Console.WriteLine(TheGarage[1].Make + "    "+TheGarage[1].Model+" " + TheGarage[1].Speed);
        }
        public void FuelAllCars()
        {
            for (int index = 0; index < TheGarage.Count; index++)
            {
                TheGarage[index].AddFuel();
            }
        }
        public Car Select_Car(int index)
        {
            Console.WriteLine("You selected Car {0}   {1}", TheGarage[index].Make, TheGarage[index].Model);
            return TheGarage[index];
        }

    }
}
