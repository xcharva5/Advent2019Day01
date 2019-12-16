using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDay01
{
    class FileReader
    {
        public static List<decimal> ReadFile(string path)
        {
            List<decimal> result = new List<decimal>();
            string line;

            StreamReader file = new StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                result.Add(Convert.ToDecimal(line));
            }

            file.Close();
            return result;
        }
    }
}
