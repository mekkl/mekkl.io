[![.NET](https://github.com/mekkl/mekkl.io/actions/workflows/wf-dotnet-build.yml/badge.svg)](https://github.com/mekkl/mekkl.io/actions/workflows/wf-dotnet-build.yml)
[![Coverage Status](https://coveralls.io/repos/github/mekkl/mekkl.io/badge.svg?branch=main)](https://coveralls.io/github/mekkl/mekkl.io?branch=main)

# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
## Setup for debug runs in VSC
TODO...

## Start the app
First download and install the .NET Core SDK [here](https://dotnet.microsoft.com/download).

> You can check to see if you have installed the .Net Core SDK version 6.0 with this command ```$ dotnet --version```

To startup the API open up a console, at the project root. 

Firstly go to the ```Presentation.WebApi``` folder:
```
$ cd Presentation.WebApi
```

Then start the API application with the following command:
```
$ dotnet run
```


The output from the command should display which url and port the API is listining on:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\ML\Desktop\portfolio-web\web-api
```

The API is documented with swagger. Just open the browser and type in the displayed url from the above output.

# Build and Test
Command for building the project (run the command at the project root):
```
$ dotnet build
```

Command for running all tests (run the command at the project root):
```
$ dotnet test
```

Command for running all tests, and generating coverage data. The result is ending op in each test project in the dir ```Tests/TestResults/<GUID>/coverage.cobertura.xml```
```
$ dotnet test --collect:"XPlat Code Coverage" --settings Tests/coverlet.runsettings
```

Command for generating coverage report from results:
```
$ reportgenerator "-reports:*\TestResults\**\coverage.cobertura.xml" "-targetdir:Tests/CoverageReports" -reporttypes:html
```
> :warning: Usage of **reportgenerator** see: https://github.com/danielpalme/ReportGenerator

## Test resources
- https://dejanstojanovic.net/aspnet/2020/may/setting-up-code-coverage-reports-in-azure-devops-pipeline/
- https://medium.com/@tarik.nzl/publishing-test-coverage-with-net-core-and-vsts-build-pipelines-39a2f29dfa12
- https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows
- Install ReportGenerator for DevOps for usage in pipeline: https://www.jamescroft.co.uk/combining-multiple-code-coverage-results-in-azure-devops/
- https://github.com/coverlet-coverage/coverlet/blob/master/Documentation/VSTestIntegration.md
- https://github.com/coverlet-coverage/coverlet
- https://coveralls.io/
