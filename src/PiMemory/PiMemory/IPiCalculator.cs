using System.Collections.Generic;

namespace PiMemory
{
    public interface IPiCalculator
    {
        IReadOnlyList<int> GetDecimals(int length);
    }
}
