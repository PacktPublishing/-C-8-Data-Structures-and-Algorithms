using System;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    public class AdvancedMeasurement
    {
        AlgorithmsToTest _test = new AlgorithmsToTest();

        [Benchmark]
        public void TestFastAlgorithm() => _test.FastAlgorithm();

        [Benchmark]
        public void TestSlowAlgorithm() => _test.SlowAlgorithm();
    }
}