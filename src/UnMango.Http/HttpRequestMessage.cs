using System;
using System.Collections.Generic;
using System.Text;

namespace UnMango.Http
{
    public class HttpRequestMessage
    {
        public HttpRequestMessage(HttpMethod method, string requestUri)
        {
            Method = method;
            RequestUri = new Uri(requestUri);
        }

        public HttpMethod Method { get; }

        public Uri RequestUri { get; set; }
    }
}
