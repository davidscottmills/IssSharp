using System;
using System.Runtime.Serialization;

namespace IssSharp.Models
{
    [DataContract]
    public class PassTime
    {
        /// <summary>
        /// The duration of the pass.
        /// </summary>
        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        /// <summary>
        /// The risetime of the pass.
        /// </summary>
        [DataMember(Name = "risetime")]
        public Int32 Risetime { get; set; }
    }
}
