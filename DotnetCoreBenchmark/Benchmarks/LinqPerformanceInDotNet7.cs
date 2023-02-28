using BenchmarkDotNet.Attributes;

namespace DotnetCoreBenchmark.Benchmarks
{
    [MemoryDiagnoser(false)]
    public class LinqPerformanceInDotNet7
    {
        [Params(100)]
        public int Size { get; set; }

        private IEnumerable<int> _items;

        [GlobalSetup]
        public void Setup()
        {
            _items = Enumerable.Range(1, Size).ToArray();
        }

        [Benchmark]
        public int Min() => _items.Min();

        [Benchmark]
        public int Max() => _items.Max();

        [Benchmark]
        public double Average() => _items.Average();

        [Benchmark]
        public int Sum() => _items.Sum();
    }
}
