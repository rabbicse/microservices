# Event Sourcing with .NET 8
Basic .NET Core 8 web api. Used the following key architectures for learning purpose only.
- Domain Driven Design (DDD)
- Command Query Responsibility Separation (CQRS)
- Event Sourcing
- Event Driven Architecture

## Prerequisites
- .NET 8
- C# 12
- EventStoreDB

## Create .NET 8 webapi project
open terminal and write the following command
```
dotnet new webapi -o EventSourcing.API 
```

## Install nuget packages by the following command
```
dotnet add package Microsoft.EntityFrameworkCore
 Microsoft.EntityFrameworkCore.Design
 Microsoft.EntityFrameworkCore.SqlServer
 Microsoft.EntityFrameworkCore.Tools
 AutoMapper
 AutoMapper.Extensions.Microsoft.DependencyInjection
```

