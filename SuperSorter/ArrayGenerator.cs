using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperSorter
{
    interface ArrayGenerator
    {
        int[] Generate(int size, int max, int seed);
    }
}
        