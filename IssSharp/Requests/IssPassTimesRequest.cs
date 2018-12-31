using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using IssSharp.Models.ResponseModels;

namespace IssSharp.Requests
{
    /// <summary>
    /// Requests a that converts a coordinate to passtime requests.
    /// </summary>
    public class IssPassTimesRequest : RequestBase
    {
        public IssPassTimesRequest(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// The latitude of the place to predict passes. Required.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude of the place to predict passes. Required.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// The number of passes to return. Optional.
        /// Default number of passes is 5.
        /// </summary>
        public int? Passes { get; set; }

        /// <summary>
        /// The altitude in meters of the place to predict passes. Optional.
        /// Default altitude is 100 meters.
        /// </summary>
        public int? Altitude { get; set; }

        public override object Execute()
        {
            var requestUrl = GetRequestUrl();

            var response = Client.DownloadString(requestUrl);

            IssPassTimeResponse result = new IssPassTimeResponse();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(response));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(result.GetType());
            result = ser.ReadObject(ms) as IssPassTimeResponse;
            ms.Close();

            return result;
        }

        public override string GetRequestUrl()
        {
            var sb = new StringBuilder(Domain);
            sb.Append("iss-pass.json?");

            if (Latitude < -80 || Latitude > 80)
                throw new Exception("Latitude must be between -80 and 80 degrees");

            sb.Append("lat=");
            sb.Append(Latitude.ToString());

            if (Longitude < -180 || Longitude > 180)
                throw new Exception("Longitude must be between -180 and 180 degrees");

            sb.Append("&lon=");
            sb.Append(Longitude.ToString());

            if (Altitude != null)
            {
                if (Altitude < 0 || Altitude > 10000)
                    throw new Exception("Altitude must be between 0 and 10000 meters");

                sb.Append("&alt=");
                sb.Append(Altitude.ToString());
            }

            if (Passes != null)
            {
                if (Passes < 1 || Passes > 100)
                    throw new Exception("Number of passes must be between 1 and 100");

                sb.Append("&n=");
                sb.Append(Passes.ToString());
            }

            return sb.ToString();
        }
    }
}
