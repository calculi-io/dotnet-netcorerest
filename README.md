# .NET Core REST Application

## Requirements

.NET Core 2.2 SDK [Download](https://dotnet.microsoft.com/download/dotnet-core/2.2)

## To Build

```powershell
dotnet build server
```

## To Run Unit Tests

```powershell
dotnet test test --logger "trx;LogFileName=TestResults.trx" /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

## To Run Integration Tests

```powershell
dotnet test integration --logger "trx;LogFileName=TestResults.trx"
```
