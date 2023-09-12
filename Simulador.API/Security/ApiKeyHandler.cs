using Simulador.Models;
using SNM.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SNM.OIRS.API.Security
{
    public class APIKeyHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                bool isValidApikey = false;
                IEnumerable<string> lsHeaders;

                var checkApiKeyExists = request.Headers.TryGetValues("API_KEY", out lsHeaders);

                if (checkApiKeyExists)
                {
                    string apikeyCliente = lsHeaders.FirstOrDefault();

                    using (SimuladorDbContext dbContext = new SimuladorDbContext())
                    {
                        isValidApikey = dbContext.APITokens.Any(x => x.Activo && x.ApiKey.ToString() == apikeyCliente);
                    }
                }

                if (request.RequestUri.AbsoluteUri.Contains("Simple"))
                    isValidApikey = true;

                if (!isValidApikey)
                    return request.CreateResponse(HttpStatusCode.Forbidden, "Bad API Key");

                var response = await base.SendAsync(request, cancellationToken);

                return response;
            }
            catch (Exception ex)
            {
                Logger.Log(ex.ToString());
                return request.CreateResponse(HttpStatusCode.InternalServerError, "Error Interno del Servidor");
            }
        }
    }
}