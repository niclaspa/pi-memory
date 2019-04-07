using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PiMemory
{
    public class StaticPiCalculator : IPiCalculator
    {
        private readonly IReadOnlyList<int> piDecimals;

        public StaticPiCalculator(string pi)
        {
            if (!Regex.IsMatch(pi, @"3\.\d+"))
            {
                throw new ArgumentException("Not a valid pi string");
            }

            this.piDecimals = pi.Split('.')[1].Select(c => Int32.Parse(c.ToString())).ToArray();
        }

        public IReadOnlyList<int> GetDecimals(int length)
        {
            if (length > this.piDecimals.Count)
            {
                throw new Exception($"Too many decimals requested. The maximum supported value is {this.piDecimals.Count}");
            }

            return this.piDecimals.Take(length).ToArray();
        }
    }
}
