using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeFeltilizer_Day5.Models
{
    public class Seed
    {
        public long SeedId {  get; set; }
        public long Soil {  get; set; }
        public long Fertilizer { get; set; }
        public long Water { get; set; }  
        public long Light { get; set; }
        public long Temperature { get; set; }
        public long Humidity { get; set; }
        public long Location { get; set; }
    }
}
