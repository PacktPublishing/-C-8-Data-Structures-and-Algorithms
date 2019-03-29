using System;
using System.Threading;

namespace Benchmark
{
    public class AlgorithmsToTest
    {
        public void FastAlgorithm()
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(1));
        }

        public void SlowAlgorithm()
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
        }
    }
}