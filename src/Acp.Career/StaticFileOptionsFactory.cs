using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using System.Linq;

namespace Acp.Career
{
    public static class StaticFileOptionsFactory
    {
        public static StaticFileOptions Create() =>
            new StaticFileOptions
            {
                OnPrepareResponse = (context) =>
                {
                    const int CachePeriodInSeconds = 31_536_000; // 1 year
                    string cacheControlHeaderValue = $"public, max-age={CachePeriodInSeconds}";
                    context.Context.Response.Headers.Append(HeaderNames.CacheControl, cacheControlHeaderValue);
                }
            });            
    }
}
