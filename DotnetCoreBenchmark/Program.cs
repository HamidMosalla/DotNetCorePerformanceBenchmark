using BenchmarkDotNet.Running;
using DotnetCoreBenchmark.Benchmarks;
// dotnet run -c Release // run in the command line
var summary = BenchmarkRunner.Run<Md5VsSha256>();