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
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package AutoMapper
```

## Run Instruction

Open terminal and run the following commands to build and run project

```
dotnet build
dotnet run
```
