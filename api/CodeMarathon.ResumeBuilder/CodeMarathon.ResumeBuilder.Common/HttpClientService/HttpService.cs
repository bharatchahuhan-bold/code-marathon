using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.Common.HttpClientService
{
    public class HttpService
    {
        #region private properties

        #endregion

        #region constructors and desctructors
        public HttpService()
        {
        }

        #endregion

        #region local constants

        #endregion

        #region public methods

        public async Task<string> Get(string apiUrl)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var res = await response.Content.ReadAsStringAsync();
                        return res;
                    }
                    else
                    {
                        throw new Exception($"There was error response for the url - {apiUrl}");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"There was exception within the HTTP Client for the url - {apiUrl}" + e.StackTrace);
            }
        }

        #endregion

        #region private methods

        #endregion
    }
}
