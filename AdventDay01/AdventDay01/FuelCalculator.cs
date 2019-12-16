using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDay01
{
    class FuelCalculator
    {
        public static decimal Calculate(List<decimal> input)
        {
            decimal totalFuel = 0;

            foreach (decimal mass in input)
            {
                decimal fuel = Math.Floor(mass/3) - 2;
                totalFuel += fuel;
            }

            return totalFuel;
        }

        public static decimal CalculateExtended(List<decimal> input)
        {
            decimal totalFuel = 0;

            foreach (decimal mass in input)
            {
                totalFuel += Calc(mass);
            }

            return totalFuel;
        }

        private static decimal Calc(decimal num)
        {
            decimal result = Math.Floor(num/3) - 2;

            if (result > 0)
                return result += Calc(result);
           
            return 0;
        }
    }
}
