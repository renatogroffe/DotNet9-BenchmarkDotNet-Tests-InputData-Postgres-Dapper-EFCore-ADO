using BenchmarkDotNet.Running;
using BenchmarkingDapperEFCoreCRM.Tests;

// Aguarda 7 segundos para se assegurar de que
// a instancia do PostgreSQL esteja ativa 
Thread.Sleep(7_000);
new BenchmarkSwitcher([typeof(CRMTests)]).Run(args);