using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnMango.Http
{
    public static class HttpClientExtensions
    {
        public static ValueTask<HttpResponseMessage> GetAsync(
            this HttpClient client,
            string requestUri,
            CancellationToken cancellationToken = default)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            return client.SendAsync(request, cancellationToken);
        }
    }
}
