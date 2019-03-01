using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSorter
{
    class BasicGenerator : ArrayGenerator
    {
        private Random rand;
        
        public int[] Generate(int size, int max, int seed)
        {
            int[] array = new int[size];

            rand = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(max);
            }

            return array;
        }
    }
}
