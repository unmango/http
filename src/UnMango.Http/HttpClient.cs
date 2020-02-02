using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnMango.Http
{
    public sealed class HttpClient : IDisposable, IAsyncDisposable
    {
        private readonly HttpMessageHandler? _pipeline;

        public HttpClient() { }

        public HttpClient(HttpMessageHandler pipeline)
        {
            _pipeline = pipeline;
        }

        public ValueTask<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken = default)
        {
            return _pipeline?.Invoke(request, next) ?? new ValueTask<HttpResponseMessage>();

            ValueTask<HttpResponseMessage> next(HttpRequestMessage innerReuest, CancellationToken innerToken)
            {
                return new ValueTask<HttpResponseMessage>();
            }
        }

        public void Dispose() => DisposeAsync().GetAwaiter().GetResult();

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
