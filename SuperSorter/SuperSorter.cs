using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperSorter
{
    abstract class SuperSorter
    {
        public void SuperSort(int[] ar)
        {
            Stopwatch _Timer = new Stopwatch();
            _Timer.Start();

            Sort(ar);

            _Timer.Stop();
            Console.WriteLine("Execution time: "+_Timer.Elapsed);
            _Timer.Reset();
        }
        protected abstract void Sort(int[] _ar);
    }
}
