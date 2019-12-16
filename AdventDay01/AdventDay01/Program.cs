using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDay01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FuelCalculator.Calculate(FileReader.ReadFile("../../../../input.txt")));
            Console.WriteLine(FuelCalculator.CalculateExtended(FileReader.ReadFile("../../../../input.txt")));
            Console.ReadKey();
        }
    }
}
