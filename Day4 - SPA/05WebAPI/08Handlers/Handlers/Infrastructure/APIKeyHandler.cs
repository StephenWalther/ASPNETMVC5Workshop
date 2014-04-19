using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Handlers.Infrastructure {
    public class APIKeyHandler: DelegatingHandler {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
            // If the headers does not contain an api key then throw
            if (request.Headers.Contains("apiKey") == false) {
                throw new HttpResponseException(HttpStatusCode.Forbidden);
            }
            
            // If the api key does not have the secret value then throw
            var apiKey = request.Headers.GetValues("apiKey").FirstOrDefault();
            if (apiKey != "SuperSecretKey") {
                throw new HttpResponseException(HttpStatusCode.Forbidden);
            }
            
            // Otherwise, move to the next handler
            return base.SendAsync(request, cancellationToken);
        }
    }
}