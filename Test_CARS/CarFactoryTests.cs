using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_Tests
{
    public class CarFactoryTests
    {
        #region Type

        [Fact]
        public void NewCar_ReturnsBMWInstance()
        {
            // Arrange
            CarTypes carType = CarTypes.BMW;

            // Act
            Car result = CarFactory.NewCar(carType);

            // Assert
            Assert.IsType<BMW>(result);
        }
        [Fact]
        public void NewCar_ReturnsNullForAudi()
        {
            // Arrange
            CarTypes carType = CarTypes.Audi;

            // Act
            Car result = CarFactory.NewCar(carType);

            // Assert
            Assert.Null(result);
        }
        #endregion Type
        #region Exception
        [Fact]
        public void NewCar_ThrowsNotImplementedExceptionForUnknownType()
        {
            // Arrange
            CarTypes carType = CarTypes.Honda;

            // Act & Assert
            Assert.Throws<NotImplementedException>(() => CarFactory.NewCar(carType));
        }
        #endregion Exception
    }
}
