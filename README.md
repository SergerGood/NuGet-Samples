Create nuspec file:
<blockquote>nuget.exe spec</blockquote>

Create nupkg file:
<blockquote>nuget.exe pack AppLogger.csproj</blockquote>

Publish package:
<blockquote>nuget.exe push SergerGoodSample.1.0.0.nupkg key -Source https://www.nuget.org/api/v2/package</blockquote>

Update Nuget:
<blockquote>nuget.exe update -self</blockquote>

NuGet 4.0:
<blockquote>msbuild "*.csproj" /t:pack /p:IncludeSymbols=true /p:Configuration=Release</blockquote>
