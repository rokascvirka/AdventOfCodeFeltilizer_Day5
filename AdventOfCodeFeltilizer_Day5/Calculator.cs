using AdventOfCodeFeltilizer_Day5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeFeltilizer_Day5
{
    public static class Calculator
    {
        public static long GetLocationForSeed(long seedId, Almanac almanac)
        {
            long soil = FindNumber(seedId, almanac.SoilMap);
            long fertilizer = FindNumber(soil, almanac.FertilizerMap);
            long water = FindNumber(fertilizer, almanac.WaterMap);
            long light = FindNumber(water, almanac.LightMap);
            long temperature = FindNumber(light, almanac.TemperatureMap);
            long humidity = FindNumber(temperature, almanac.HumidityMap);
            long location = FindNumber(humidity, almanac.LocationMap);

            return location;
        }
        public static long FindNumber(long number, List<Instructions> instructions)
        {
            foreach (var instruction in instructions)
            {
                if( number >= instruction.SourceRange && number < instruction.SourceRange + instruction.RangeLength)
                {
                    return instruction.DestinationRange + (number - instruction.SourceRange);
                }
            }
            return number;
        }
    }
}
