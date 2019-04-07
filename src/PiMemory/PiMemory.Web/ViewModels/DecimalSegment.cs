using System.Collections.Generic;

namespace PiMemory.Web.ViewModels
{
    public class DecimalSegment
    {
        public IReadOnlyList<int> Digits { get; set; }
        public int Offset { get; set; }
    }
}
