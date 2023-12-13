using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeFeltilizer_Day5.Models
{
    public class Almanac
    {
        public List<Seed> Seeds { get; set; }
        public List<Seed> UpdatedSeeds { get; set; }
        public List<Instructions> SoilMap { get; set; }
        public List<Instructions> FertilizerMap { get; set; }
        public List<Instructions> WaterMap { get; set; }
        public List<Instructions> LightMap { get;set; }
        public List<Instructions> TemperatureMap { get; set; }
        public List<Instructions> HumidityMap { get; set; }
        public List<Instructions> LocationMap { get; set; }

        public Almanac()
        {
            Seeds = new List<Seed>(); 
            UpdatedSeeds = new List<Seed>();
            SoilMap = new List<Instructions>();
            WaterMap = new List<Instructions>();
            LightMap = new List<Instructions>();
            TemperatureMap = new List<Instructions>();
            HumidityMap = new List<Instructions>();
            LocationMap = new List<Instructions>();
        }
    }
}
