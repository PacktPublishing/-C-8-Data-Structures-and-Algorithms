using System;
using System.Diagnostics;

namespace Benchmark
{
    public static class NaiveMeasurement
    {
        public static void Measure()
        {
            var test = new AlgorithmsToTest();
            var sw = Stopwatch.StartNew();
            for(int i = 0; i < 100; i++)
            {
                test.FastAlgorithm();
            }
            sw.Stop();
            Console.WriteLine("Fast algorithm : " +
                $"{(double)sw.ElapsedMilliseconds/100} ms");
            sw.Restart();
            for(int i = 0; i < 100; i++) 
            {
                test.SlowAlgorithm();
            }
            sw.Stop();
            Console.WriteLine("Slow algorithm : " + 
                $"{(double)sw.ElapsedMilliseconds/100} ms");
        }
    }
}