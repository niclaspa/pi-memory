using System;
using System.Linq;
using Moq;
using Xunit;

namespace PiMemory.Tests
{
    public class PiServiceTests
    {
        [Theory]
        [InlineData(1, 1, "0123456789", "1")]
        [InlineData(1, 2, "0123456789", "12")]
        [InlineData(0, 2, "0123456789", "01")]
        public void DecimalsAreReturnedWithCorrectOffsetAndLength(int offset, int length, string digits, string expected)
        {
            var service = TestSetup(digits);

            var actualDigits = service.GetDecimalsCached(offset, length);
            var expectedDigits = expected.Select(c => Int32.Parse(c.ToString())).ToArray();

            Assert.True(actualDigits.SequenceEqual(expectedDigits));
        }

        private static PiService TestSetup(string digits)
        {
            var mockCalculator = new Mock<IPiCalculator>();
            mockCalculator
                .Setup(x => x.GetDecimals(It.IsAny<int>()))
                .Returns((int requiredLength) => digits.Select(c => Int32.Parse(c.ToString())).ToArray());

            var service = new PiService(mockCalculator.Object);

            return service;
        }
    }
}
