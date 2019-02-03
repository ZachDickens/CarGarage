using System;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            var xxx = new Garage();

            // Act
            xxx.AddCar("Ford" , "Focus");

            // Assert
            Assert.NotEmpty(xxx.TheGarage);
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            var xxx = new Garage();
            xxx.AddCar("Ford", "Focus");

            // Act
            xxx.RemoveCar(0);

            // Assert
            Assert.Empty(xxx.TheGarage);
            
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            var xxx = new Garage();
            xxx.AddCar("Ford", "Focus"); //0 in my list      xxx   Garage[index] 
            xxx.TheGarage[0].Accelerate();
            xxx.TheGarage[0].Accelerate();
            xxx.TheGarage[0].Accelerate();
            xxx.TheGarage[0].Accelerate();
            // Act
            xxx.FuelAllCars();

            // Assert
            Assert.Equal(100, xxx.TheGarage[0].GasLevel);
        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car

            // Program class should then let you choose what you want to do with that car

            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
