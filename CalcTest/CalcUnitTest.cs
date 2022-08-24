using ConsoleCalc;

namespace CalcTest
{
    public class CalcUnitTest
    {
        [Fact(DisplayName = "Sum 2 numbers")]
        [Trait("Calc", "Sum")]
        public void Sum2Numbers()
        {
            //Arrange - Organizar
            var number1 = 8.9;
            var number2 = 10.12;
            var expectedValue = 19.02;

            //Act - Agir
            var result = Calc.Sum(number1, number2);

            //Assert - Assertir
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        [Trait("Calc", "Subtract")]
        public void Subtract2Numbers()
        {
            //Arrange - Organizar
            var number1 = 8.9;
            var number2 = 10.12;
            var expectedValue = 1.22;

            //Act - Agir
            var result = Calc.Subtract(number2, number1);

            //Assert - Assertir
            Assert.Equal(expectedValue, result, 2);
        }

        [Fact]
        [Trait("Calc", "Divide")]
        public void Divide2Numbers()
        {
            //Arrange - Organizar
            var number1 = 18;
            var number2 = 2;
            var expectedValue = 9;

            //Act - Agir
            var result = Calc.Divide(number1, number2);

            //Assert - Assertir
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        [Trait("Calc", "Multiply")]
        public void Multiply2Numbers()
        {
            //Arrange - Organizar
            var number1 = 5.5;
            var number2 = 2;
            var expectedValue = 11;

            //Act - Agir
            var result = Calc.Multiply(number1, number2);

            //Assert - Assertir
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(-4,-6,-10)]
        [InlineData(-2,2,0)]
        [InlineData(int.MinValue, +1, int.MinValue+1)]
        public void Sum2RelativeNumbers_ResultRelativeNumber(int number1, int number2, int expectedValue)
        {
            var result = Calc.Sum(number1, number2);
            Assert.Equal(expectedValue, result);
        }

        [Fact(Skip = "Test not available yet")]
        public void TestNotAvailable()
        {
            
        }
    }
}
