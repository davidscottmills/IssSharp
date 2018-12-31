using System.Runtime.Serialization;

namespace IssSharp.Models.ResponseModels
{
    [DataContract]
    public class ResponseBase
    {
        /// <summary>
        /// Response message.
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
