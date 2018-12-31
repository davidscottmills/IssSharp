using System.Runtime.Serialization;

namespace IssSharp.Models.ResponseModels
{
    [DataContract]
    public class IssPassTimeResponse : ResponseBase
    {
        /// <summary>
        /// The submitted passtime request.
        /// </summary>
        [DataMember(Name = "request")]
        public PassTimeRequestResponse Request { get; set; }

        /// <summary>
        /// The passtime responses.
        /// </summary>
        [DataMember(Name = "response")]
        public PassTime[] PassTimes { get; set; }
    }
}