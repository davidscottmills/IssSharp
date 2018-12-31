using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssSharp.Models.ResponseModels;
using IssSharp.Requests;

namespace IssSharp.Tests
{
    [TestClass]
    public class IssSharpTests
    {
        [TestMethod]
        public void IssSharpTests_GetLocation()
        {
            var issLocationRequest = new IssLocationRequest();
            var locResponse = issLocationRequest.Execute() as IssLocationResponse;
            Assert.IsNotNull(locResponse);
        }

        [TestMethod]
        public void IssSharpTests_GetPassTimes_LocationOnly()
        {
            var lat = 40.014984;
            var lon = -105.270546;
            var passTimeRequest = new IssPassTimesRequest(lat, lon);
            var passTimeResponse = passTimeRequest.Execute() as IssPassTimeResponse;
            Assert.IsNotNull(passTimeResponse);
            Assert.AreEqual(lat, passTimeResponse.Request.Latitude);
            Assert.AreEqual(lon, passTimeResponse.Request.Longitude);
        }

        [TestMethod]
        public void IssSharpTests_GetPassTimes_WithAltitude()
        {
            var lat = 40.014984;
            var lon = -105.270546;
            var altitude = 1000;
            var passTimeRequest = new IssPassTimesRequest(lat, lon)
            {
                Altitude = altitude
            };
            var passTimeResponse = passTimeRequest.Execute() as IssPassTimeResponse;
            Assert.IsNotNull(passTimeResponse);
            Assert.AreEqual(lat, passTimeResponse.Request.Latitude);
            Assert.AreEqual(lon, passTimeResponse.Request.Longitude);
            Assert.AreEqual(altitude, passTimeResponse.Request.Altitude);
        }

        [TestMethod]
        public void IssSharpTests_GetPassTimes_WithNumPasses()
        {
            var lat = 40.014984;
            var lon = -105.270546;
            var passes = 3;
            var passTimeRequest = new IssPassTimesRequest(lat, lon)
            {
                Passes = passes
            };
            var passTimeResponse = passTimeRequest.Execute() as IssPassTimeResponse;
            Assert.IsNotNull(passTimeResponse);
            Assert.AreEqual(lat, passTimeResponse.Request.Latitude);
            Assert.AreEqual(lon, passTimeResponse.Request.Longitude);
            Assert.AreEqual(passes, passTimeResponse.Request.Passes);
        }

        [TestMethod]
        public void IssSharpTests_GetPassTimes_WithPassesAndAltitude()
        {
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
            Assert.IsNotNull(passTimeResponse);
            Assert.AreEqual(lat, passTimeResponse.Request.Latitude);
            Assert.AreEqual(lon, passTimeResponse.Request.Longitude);
            Assert.AreEqual(passes, passTimeResponse.Request.Passes);
            Assert.AreEqual(altitude, passTimeResponse.Request.Altitude);
        }
    }
}
