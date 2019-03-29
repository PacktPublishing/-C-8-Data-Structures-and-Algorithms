using System;
using System.Collections.Generic;
using System.Security.Cryptography;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AlgorithmSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var summary = BenchmarkRunner.Run<AlgorithmBenchmark>();
        }
    }

    public class ListCheck
    {
        private List<string> _list = new List<string>();
        public bool CheckIfStringIsUnique(string s)
        {
            if(_list.Contains(s)) return false;

            _list.Add(s);
            return true;
        }
    }
    public class HashSetCheck
    {
        private HashSet<string> _set = new HashSet<string>();
        public bool CheckIfStringIsUnique(string s)
        {
            if(_set.Contains(s)) return false;

            _set.Add(s);
            return true;
        }
    }

    #region Benchmark
    [SimpleJob(launchCount: 1, warmupCount: 1, targetCount: 10)]
    public class AlgorithmBenchmark
    {
        ListCheck _listCheck = new ListCheck();
        HashSetCheck _setCheck = new HashSetCheck();

        string GetRandomString()
        {
            return Guid.NewGuid().ToString();
        }

        [Benchmark]
        public void ListCheckBenchmark() => 
            _listCheck.CheckIfStringIsUnique(GetRandomString());

        [Benchmark]
        public void HashSetCheckBenchmark() =>
            _setCheck.CheckIfStringIsUnique(GetRandomString());
    }
    #endregion
}
