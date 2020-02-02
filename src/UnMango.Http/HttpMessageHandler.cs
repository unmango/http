using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnMango.Http
{
    public delegate ValueTask<HttpResponseMessage> HttpMessageHandler(
        HttpRequestMessage request,
        Func<HttpRequestMessage, CancellationToken, ValueTask<HttpResponseMessage>> next);
}
