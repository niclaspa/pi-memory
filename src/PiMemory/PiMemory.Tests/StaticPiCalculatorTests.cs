using System;
using System.Linq;
using Xunit;

namespace PiMemory.Tests
{
    public class StaticPiCalculatorTests
    {
        [Theory]
        [InlineData("3.1")]
        [InlineData("3.14")]
        [InlineData("3.14159265358979323846264338")]
        public void PiIsCalculatedCorrectly(string expectedPi)
        {
            var decimals = expectedPi.Split('.')[1].Select(c => Int32.Parse(c.ToString())).ToArray();

            var calc = new StaticPiCalculator("3.14159265358979323846264338");
            var actual = calc.GetDecimals(decimals.Length);
            
            Assert.True(decimals.SequenceEqual(actual));
        }

        [Fact]
        public void ExceptionIsThrownWhenTooManyDecimalsAreRequested()
        {
            var calc = new StaticPiCalculator("3.14");
            Assert.Throws<Exception>(() => calc.GetDecimals(3));
        }
    }
}
