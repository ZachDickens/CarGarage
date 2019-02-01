using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> TheGarage;

        public void AddCar()
        {
            TheGarage.Add(new Car());
        }

        public Garage()
        {
            TheGarage = new List<Car>();
        }
    }
}
