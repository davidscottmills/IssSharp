using System;
using System.Runtime.Serialization;

namespace IssSharp.Models
{
    [DataContract]
    public class PassTimeRequestResponse
    {
        /// <summary>
        /// Latitude of the passtime request.
        /// </summary>
        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude of the passtime request.
        /// </summary>
        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Number of passes requested.
        /// </summary>
        [DataMember(Name = "passes")]
        public int Passes { get; set; }

        /// <summary>
        /// The datetime of the request.
        /// </summary>
        [DataMember(Name = "datetime")]
        public Int32 DateTime { get; set; }

        /// <summary>
        /// The altitude of the request.
        /// </summary>
        [DataMember(Name = "altitude")]
        public int Altitude { get; set; }
    }
}