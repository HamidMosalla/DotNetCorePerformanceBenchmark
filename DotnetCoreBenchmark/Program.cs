using BenchmarkDotNet.Running;
using DotnetCoreBenchmark.Benchmarks;


 //dotnet run -c Release // run in the command line



 // BenchmarkRunner.Run<Md5VsSha256>();
 BenchmarkRunner.Run<LinqPerformanceInDotNet7>();