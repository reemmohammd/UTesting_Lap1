using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_Tests
{
    #region Collection
    public class CarStoreTests
    {
        [Fact]
        public void AddCar_AddsCarToList()
        {
            // Arrange
            CarStore store = new CarStore();
            Car car = new Toyota();

            // Act
            store.AddCar(car);

            // Assert
            Assert.Contains(car, store.cars);
        }
        [Fact]
        public void AddCars_AddsCarsToList()
        {
            // Arrange
            CarStore store = new CarStore();
            List<Car> carsGroup = new List<Car> { new Toyota(), new BMW() };

            // Act
            store.AddCars(carsGroup);

            // Assert
            Assert.All(carsGroup, c => Assert.Contains(c, store.cars));
        }
        #endregion Collection
    }
}
