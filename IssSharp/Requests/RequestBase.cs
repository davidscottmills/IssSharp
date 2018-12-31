using System.Net;
using System.Threading.Tasks;

namespace IssSharp.Requests
{
    public abstract class RequestBase
    {
        /// <summary>
        /// The domain of the REST service. Default: http://api.open-notify.org/
        /// </summary>
        public string Domain
        {
            get
            {
                return "http://api.open-notify.org/";
            }
        }

        public WebClient Client => new WebClient();

        /// <summary>
        /// Abstract method which generates the REST request URL.
        /// </summary>
        /// <returns>An open-notify REST request URL.</returns>
        public abstract string GetRequestUrl();

        /// <summary>
        /// Abstract method that executes the request.
        /// </summary>
        /// <returns>An open-notify response.</returns>
        public abstract object Execute();
    }
}
