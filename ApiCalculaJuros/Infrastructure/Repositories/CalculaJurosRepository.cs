using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Domian.Respositories;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories
{
    public class CalculaJurosRepository : ICalculaJurosRepository
    {
        private const string route = "TaxaJuros";
        public HttpClient  _client;
        private ILogger<CalculaJurosRepository> _logger;

        public CalculaJurosRepository(HttpClient client, ILogger<CalculaJurosRepository> logger)
        {
            _client = client;
            _logger = logger;
        }

        public  async Task<double> getTaxa()
        {
            try{
                var response = await _client.GetAsync(requestUri: route );
                if(response.StatusCode != HttpStatusCode.OK){
                    return -1;  
                }
                var responseString  = await response.Content.ReadAsStringAsync();
                Double taxaJuros = Convert.ToDouble(
                    responseString,
                    new NumberFormatInfo {NumberDecimalSeparator = "."});
                return taxaJuros;
            }catch(Exception e){
              _logger.LogError(e.Message);
                return -1;
            }

            
        }
    }
}