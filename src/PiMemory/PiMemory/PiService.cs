using System.Collections.Generic;
using System.Linq;

namespace PiMemory
{
    public interface IPiService
    {
        IReadOnlyList<int> GetDecimalsCached(int offset, int length);
    }

    public class PiService : IPiService
    {
        private readonly IPiCalculator calculator;

        public PiService(IPiCalculator calculator)
        {
            this.calculator = calculator;
        }

        public IReadOnlyList<int> GetDecimalsCached(int offset, int length)
        {
            var requiredLength = offset + length;

            var decimals = this.calculator.GetDecimals(requiredLength);

            return decimals.Skip(offset).Take(length).ToArray();
        }
    }
}
