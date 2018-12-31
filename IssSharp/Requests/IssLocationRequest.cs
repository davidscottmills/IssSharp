using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using IssSharp.Models.ResponseModels;

namespace IssSharp.Requests
{
    public class IssLocationRequest : RequestBase
    {
        public override object Execute()
        {
            var requestUrl = GetRequestUrl();
            var response = Client.DownloadString(requestUrl);

            IssLocationResponse result = new IssLocationResponse();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(response));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(result.GetType());
            result = ser.ReadObject(ms) as IssLocationResponse;
            ms.Close();

            return result;
        }

        public override string GetRequestUrl()
        {
            var sb = new StringBuilder(Domain);
            sb.Append("iss-now.json");
            return sb.ToString();
        }
    }
}
