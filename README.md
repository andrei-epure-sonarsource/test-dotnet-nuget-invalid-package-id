# Invalid NuGet package ID fixture

This is an intentionally broken .NET project for SonarQube Cloud automatic-analysis testing.

`invalid/package` is not a valid NuGet package ID. When the AutoScan.NET NuGet resolver reads the project file, NuGet throws `NuGet.Packaging.InvalidPackageIdException`. The resolver should log the error, emit a `NuGetResolutionErrorCount` metric with `Reason=InvalidPackageIdException`, skip the bad reference, resolve `Newtonsoft.Json`, and complete analysis.

The application code is otherwise real and uses `Newtonsoft.Json`. A normal `dotnet restore` or `dotnet build` is expected to fail because the invalid reference is deliberate; use automatic analysis to exercise the continuation behavior.
