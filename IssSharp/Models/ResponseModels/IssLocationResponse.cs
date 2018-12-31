using System;
using System.Runtime.Serialization;

namespace IssSharp.Models.ResponseModels
{
    [DataContract]
    public class IssLocationResponse : ResponseBase
    {
        /// <summary>
        /// Current position of the International Space Station.
        /// </summary>
        [DataMember(Name = "iss_position")]
        public Coordinate IssPosition { get; set; }

        /// <summary>
        /// Time of the request.
        /// </summary>
        [DataMember(Name = "timestamp")]
        public Int32 TimeStamp { get; set; }
    }
}