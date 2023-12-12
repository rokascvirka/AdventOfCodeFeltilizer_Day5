using AdventOfCodeFeltilizer_Day5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeFeltilizer_Day5
{
    public static class FileManager
    {
        public static Almanac ReadFile(string filePath)
        {
            var almanac = new Almanac();
            using(StreamReader sr = new StreamReader(filePath)) 
            {
                var text = sr.ReadToEnd().Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach(var line in text)
                {
                    var lineText = line.Split(":");
                    if (line.StartsWith("seeds"))
                    {
                        ProcessSeeds(almanac, lineText[1]);
                    }
                    else if (line.StartsWith("seed"))
                    {
                        ProcessMap(almanac, "soil", lineText[1]);
                    }
                    else if (line.StartsWith("soil"))
                    {
                        ProcessMap(almanac, "fertilizer", lineText[1]);
                    }
                    else if (line.StartsWith("fertilizer"))
                    {
                        ProcessMap(almanac, "water", lineText[1]);
                    }
                    else if (line.StartsWith("water"))
                    {
                        ProcessMap(almanac, "light", lineText[1]);
                    }
                    else if (line.StartsWith("light"))
                    {
                        ProcessMap(almanac, "temperature", lineText[1]);
                    }
                    else if (line.StartsWith("temperature"))
                    {
                        ProcessMap(almanac, "humidity", lineText[1]);
                    }
                    else if (line.StartsWith("humidity"))
                    {
                        ProcessMap(almanac, "location", lineText[1]);
                    }
                }
            }
            return almanac;
        }
        private static void ProcessSeeds(Almanac almanac, string data)
        {
            var coordinates = data.Trim().Split(" ");
            foreach (var item in coordinates)
            {
                almanac.Seeds.Add( new Seed() {  SeedId = long.Parse(item) });
            }
        }
        private static void ProcessMap(Almanac almanac, string mapType, string data)
        {
            var instructions = GetInstructions(data);
            switch(mapType)
            {
                case "soil":
                    almanac.SoilMap = instructions;
                    break;
                case "fertilizer":
                    almanac.FertilizerMap = instructions;
                    break;
                case "water":
                    almanac.WaterMap = instructions;
                    break;
                case "light":
                    almanac.LightMap = instructions;
                    break;
                case "temperature":
                    almanac.TemperatureMap = instructions;
                    break;
                case "humidity":
                    almanac.HumidityMap = instructions;
                    break;
                case "location":
                    almanac.LocationMap = instructions;
                    break;
                default:
                    break;
            }
        }

        private static List<Instructions> GetInstructions(string lineText)
        {
            var allInstructions = new List<Instructions>();
            var allValues = lineText.Split(Environment.NewLine);
            foreach (var value in allValues) 
            {
                if(value != string.Empty)
                {
                    var instructions = value.Trim().Split(" ");
                    var destinationRange = long.Parse(instructions[0]);
                    var sourceRange = long.Parse(instructions[1]);
                    var rangeLength = long.Parse(instructions[2]);
                    allInstructions.Add(new Instructions(destinationRange, sourceRange, rangeLength));
                }
            }
            return allInstructions;
        }

    }
}
