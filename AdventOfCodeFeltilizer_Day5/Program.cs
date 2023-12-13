using AdventOfCodeFeltilizer_Day5.Models;
using System.Reflection;

namespace AdventOfCodeFeltilizer_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay5.txt");
            var almanac = FileManager.ReadFile(FILE_PATH);
            var sortedAlmanac = OrderAlmanac(almanac);
            
            var locationNumbers = new List<long>();
            foreach(var seed in sortedAlmanac.Seeds)
            {
                seed.Location = Calculator.GetLocationForSeed(seed.SeedId, sortedAlmanac);
                locationNumbers.Add(seed.Location);
            }
            long lowestLocationNumber = locationNumbers.Min();

            Calculator.UpdateSeeds(almanac);
            Console.WriteLine($"Seeds count: {almanac.Seeds.Count}, updated seeds count: {almanac.UpdatedSeeds.Count}");
            Console.WriteLine($"Location number: {lowestLocationNumber}");
        }

        private static Almanac OrderAlmanac(Almanac almanac)
        {
            almanac.SoilMap = almanac.SoilMap = almanac.SoilMap.OrderBy(x => x.DestinationRange).ToList();
            almanac.FertilizerMap =  almanac.FertilizerMap.OrderBy(x => x.DestinationRange).ToList();
            almanac.WaterMap = almanac.WaterMap.OrderBy(x => x.DestinationRange).ToList();
            almanac.LightMap = almanac.LightMap.OrderBy(x => x.DestinationRange).ToList();
            almanac.TemperatureMap = almanac.TemperatureMap.OrderBy(x => x.DestinationRange).ToList();
            almanac.HumidityMap = almanac.HumidityMap.OrderBy(x => x.DestinationRange).ToList();
            almanac.LocationMap = almanac.LocationMap.OrderBy(x => x.DestinationRange).ToList();

            return almanac;
        }
    }   
}