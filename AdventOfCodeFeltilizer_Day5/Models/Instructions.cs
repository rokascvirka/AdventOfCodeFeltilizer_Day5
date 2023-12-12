using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeFeltilizer_Day5.Models
{
    public class Instructions
    {
        public long DestinationRange { get; set; }
        public long SourceRange { get; set; }
        public long RangeLength { get; set; }

        public Instructions(long destinationRange, long sourceRange, long rangeLength)
        {
            DestinationRange = destinationRange;
            SourceRange = sourceRange;
            RangeLength = rangeLength;
        }
    }
}
