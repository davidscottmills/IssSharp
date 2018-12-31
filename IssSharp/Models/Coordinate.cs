using System.Runtime.Serialization;

namespace IssSharp.Models
{
    [DataContract(Name = "iss_position")]
    public class Coordinate
    {
        /// <summary>
        /// Latitude coordinate.
        /// </summary>
        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude coordinate.
        /// </summary>
        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }
    }
}
