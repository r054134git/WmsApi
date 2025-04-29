using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ApiTracker
{
    class CustomHeaderHandler : DelegatingHandler
    {
        public CustomHeaderHandler()
        {
			if (InnerHandler == null)
			{
                InnerHandler = new HttpClientHandler()
				{
					ServerCertificateCustomValidationCallback = (message, cert, chain, sslErrors) => true

				};
			}
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
