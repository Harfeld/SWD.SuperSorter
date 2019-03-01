using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayGenerator gen = new ArrayGenerator();
            int[] test = gen.Generate(5, 10, 1);

            foreach (var num in test)
            {
                Console.WriteLine(num);
            }
        }
    }
}
