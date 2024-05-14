using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_Tests
{
    public class ToyotaTests
    {
        #region Boolean
        [Fact]
        public void IsStopped_ReturnsTrueWhenVelocityIsZero()
        {
            // Arrange
            Car car = new Toyota();
            car.velocity = 0;

            // Act
            bool result = car.IsStopped();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsStopped_ReturnsFalseWhenVelocityIsNotZero()
        {
            // Arrange
            Car car = new Toyota();
            car.velocity = -4;

            // Act
            bool result = car.IsStopped();

            // Assert
            Assert.False(result);
        }
        #endregion Boolean
        #region Numeric
        [Fact]
        public void IncreaseVelocity_StartingVelocityNegative10_AddedVelocity30_Velocity20()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = -10 };
            double addedVelocity = 30;

            // Act
            toyota.IncreaseVelocity(addedVelocity);

            // Assert
            Assert.Equal(20, toyota.velocity);
        }
        [Fact]
        public void IncreaseVelocity_StartingVelocityNegative50_AddedVelocity100_Velocity50()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = -50 };
            double addedVelocity = 100;

            // Act
            toyota.IncreaseVelocity(addedVelocity);

            // Assert
            Assert.Equal(50, toyota.velocity);
        }
        #endregion Numeric
        #region String
        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Backward };
            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Backward", result);
            Assert.StartsWith("B", result);
            Assert.EndsWith("rd", result);
            Assert.Contains("wa", result);
            Assert.DoesNotContain("xyz", result);
            Assert.Matches("[A-Z][a-z]{7}", result);
            Assert.DoesNotMatch("[A-Z][a-z]{10}", result);
        }
        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };
            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Forward", result);
            Assert.StartsWith("F", result);
            Assert.EndsWith("rd", result);
            Assert.Contains("wa", result);
            Assert.DoesNotContain("xyz", result);
            Assert.Matches("[A-Z][a-z]{7}", result);
            Assert.DoesNotMatch("[A-Z][a-z]{10}", result);
        }
        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Stopped };
            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Stopped", result);
            Assert.StartsWith("S", result);
            Assert.EndsWith("ped", result);
            Assert.Contains("opp", result);
            Assert.DoesNotContain("xyz", result);
            Assert.Matches("[A-Z][a-z]{6}", result);
            Assert.DoesNotMatch("[A-Z][a-z]{10}", result);
        }
        [Fact]
        public void GetDirection_DirectionUnknown_Unknown()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = (DrivingMode)100 }; // An unknown driving mode
            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Unknown", result);
            Assert.StartsWith("U", result);
            Assert.EndsWith("n", result);
            Assert.Contains("nown", result);
            Assert.DoesNotContain("xyz", result);
            Assert.Matches("[A-Z][a-z]{6}", result);
            Assert.DoesNotMatch("[A-Z][a-z]{10}", result);
        }

        #endregion String
        #region Reference
        [Fact]
        public void GetMyCar_ReturnsSameReference()
        {
            // Arrange
            Toyota toyota1 = new Toyota();
            Toyota toyota2 = new Toyota();

            // Act
            Car result1 = toyota1.GetMyCar();
            Car result2 = toyota2.GetMyCar();

            // Assert
            Assert.Same(toyota1, result1);
            Assert.Same(toyota2, result2);
        }
        [Fact]
        public void GetMyCar_ReturnsDifferentReferenceForDifferentInstances()
        {
            // Arrange
            Toyota toyota1 = new Toyota();
            Toyota toyota2 = new Toyota();

            // Act
            Car result1 = toyota1.GetMyCar();
            Car result2 = toyota2.GetMyCar();

            // Assert
            Assert.NotSame(toyota1, toyota2);
            Assert.NotSame(result1, result2);
        }
        #endregion Reference

    }
}
