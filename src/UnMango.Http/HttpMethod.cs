using System;

namespace UnMango.Http
{
    public class HttpMethod
    {
        private HttpMethod() { }

        public static HttpMethod Get => new HttpMethod();

        public static HttpMethod Post => new HttpMethod();

        public static HttpMethod Put => new HttpMethod();

        public static HttpMethod Delete => new HttpMethod();
    }
}
