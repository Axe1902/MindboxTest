namespace SquareCalculator.Tests
{
    public class SquareCalculatorUnitTests
    {
        [Fact]
        public void CalculateCircle_CorrectSquare()
        {
            var square = Core.SquareCalculator.CalculateCircle(1);

            Assert.Equal(Math.PI, square);
        }

        [Fact]
        public void CalculateCircle_InvalidRadius_Exception()
        {
            Assert.Throws<ArgumentException>(() => Core.SquareCalculator.CalculateCircle(-1));
        }

        [Fact]
        public void CalculateTriangle_CorrectSquare()
        {
            var square = Core.SquareCalculator.CalculateTriangle(3, 4, 5);

            Assert.Equal(6, square);
        }

        [Fact]
        public void CalculateTriangle_InvalidSides_Exception()
        {
            Assert.Throws<ArgumentException>(() => Core.SquareCalculator.CalculateTriangle(10, 1, 1));
        }
    }
}