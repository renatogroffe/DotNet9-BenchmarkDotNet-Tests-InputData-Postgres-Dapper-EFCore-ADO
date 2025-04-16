$env:NumeroContatosPorCompanhia = "2"
$env:BaseEFCoreConnectionString = "Server=localhost;Port=5432;Database=basecrmef;User Id=postgres;Password=Postgres2025!"
$env:BaseDapperConnectionString = "Server=localhost;Port=5432;Database=basecrmdapper;User Id=postgres;Password=Postgres2025!"
$env:BaseADOConnectionString = "Server=localhost;Port=5432;Database=basecrmado;User Id=postgres;Password=Postgres2025!"
dotnet run --filter BenchmarkingDapperEFCoreCRM.Tests.* -c Release