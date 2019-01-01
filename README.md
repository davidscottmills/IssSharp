# IssSharp
IssSharp is a package for consuming the REST api found at OpenNotify, which provides information on the location and passtimes of the International Space Station.

# Installing
Package Manager
```
PM > Install-Package DavidSMills.IssSharp -Version 1.0.1
```
.Net CLI
```
> dotnet add package DavidSMills.IssSharp --version 1.0.1
```

# Example Usage

Get Current ISS Location

```c#
var issLocationRequest = new IssLocationRequest();
var locResponse = issLocationRequest.Execute() as IssLocationResponse;
```

Get ISS Pass Times for Location
```c#
var lat = 40.014984;
var lon = -105.270546;
var passes = 3;
var altitude = 1000;
var passTimeRequest = new IssPassTimesRequest(lat, lon)
{
    Passes = passes,
    Altitude = altitude
};
var passTimeResponse = passTimeRequest.Execute() as IssPassTimeResponse;
```
# Release Notes

## Version 1.0.1
Remove unnecessary reference to Newtonsoft package.

## Version 1.0.0
Initial release.
