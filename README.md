# IssSharp
IssSharp is a package for consuming the REST api found at OpenNotify, which provides information on the location and passtimes of the International Space Station.

# Example Usage

Get Current ISS Location

```c#
var issLocationRequest = new IssLocationRequest();
var locResponse = issLocationRequest.Execute() as IssLocationResponse;
```

Get Iss Pass Times
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
