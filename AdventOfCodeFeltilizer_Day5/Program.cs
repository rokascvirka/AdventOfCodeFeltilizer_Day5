using System.Reflection;

namespace AdventOfCodeFeltilizer_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay5.txt");
            var text = FileManager.ReadFile(FILE_PATH);
        }
    }   
}