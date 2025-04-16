namespace BenchmarkingDapperEFCoreCRM;

public static class Configurations
{
    public static string BaseEFCore => Environment.GetEnvironmentVariable("BaseEFCoreConnectionString")!;
    public static string BaseDapper => Environment.GetEnvironmentVariable("BaseDapperConnectionString")!;
    public static string BaseADO => Environment.GetEnvironmentVariable("BaseADOConnectionString")!;
}