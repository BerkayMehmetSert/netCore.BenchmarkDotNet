using BenchmarkDotNet.Running;
using WebAPI.Application.Performances;

var summary = BenchmarkRunner.Run<ProductsControllerBenchmark>();

