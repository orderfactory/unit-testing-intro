using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace FancyLibrary.Tests
{
    public class RateCalculatorTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(199, "199")]
        [InlineData(3, "Fiz")]
        [InlineData(3 * 193 * 197, "Fiz")]
        [InlineData(5, "Buz")]
        [InlineData(5 * 193 * 197 * 199, "Buz")]
        [InlineData(15, "FizBuz")]
        [InlineData(15 * 1024 * 1024, "FizBuz")]
        [InlineData(-15 * 1024 * 1024, "FizBuz")]
        public async Task GivenAnIntegerWhenFizBuzThenProduceString(int input, string expected)
        {
            var calculator = new RateCalculator();

            var output = await calculator.FizBuz(input);

            output.Should().Be(expected);
        }

        [Fact]
        public async Task GivenThreeWhenFizBuzThenFiz()
        {
            //AAA

            //Arrange
            var calculator = new RateCalculator();
            const int input = 3;

            //Act
            var output = await calculator.FizBuz(input);

            //Assert
            output.Should().Be("Fiz");
        }
    }
}