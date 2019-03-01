using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperSorter
{
    class ArrayGenerator
    {   
        private Random rand;

        public int[] Generate(int size, int max, int seed)
        {
            int[] array = new int[size];
            Fill(array, max, seed);
            return array;
        }

        private void Fill(int[] ar, int max, int seed)
        {
            rand = new Random(seed);
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.Next(max);
            }
        }
     }
}
        