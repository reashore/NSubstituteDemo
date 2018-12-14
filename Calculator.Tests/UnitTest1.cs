using NUnit.Framework;
using NSubstitute;
using Calculator.Domain;


namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionTest()
        {
            // Arrange
            HandCalculator handCalculator = new HandCalculator();
            const int expectedResult = 6;
            
            // Act
            int result = handCalculator.Add(2, 4);
            
            // Assert
            Assert.AreEqual(expectedResult, result);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void AdditionUsingNSubstituteTest()
        {
            // Arrange
            var handCalculator = Substitute.For<IHandCalculator>();
            const int expectedResult = 6;
            handCalculator.Add(2, 4).Returns(expectedResult);
            
            // Act
            int result = handCalculator.Add(2, 4);
            
            // Assert
            Assert.AreEqual(expectedResult, result);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void SomeTest()
        {
            Assert.Pass();
        }
    }
}