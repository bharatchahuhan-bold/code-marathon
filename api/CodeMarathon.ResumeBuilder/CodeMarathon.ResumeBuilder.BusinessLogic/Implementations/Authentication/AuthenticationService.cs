using CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.Authentication;
using CodeMarathon.ResumeBuilder.Common;
using CodeMarathon.ResumeBuilder.Common.HttpClientService;
using CodeMarathon.ResumeBuilder.DTOs.Authentication;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.BusinessLogic.Implementations.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        #region private properties

        private IConfiguration _configuration;
        private HttpService _httpService;

        #endregion

        #region constructors and desctructors
        public AuthenticationService(IConfiguration configuration,
                                     HttpService httpService)
        {
            _configuration = configuration;
            _httpService = httpService;
        }

        #endregion

        #region local constants

        #endregion

        #region public methods

        public async Task<string> SignInWithLinkedIn(AuthenticationRequest authRequest)
        {
            var apiBaseUrl = _configuration.GetSection("apiUrl")?.Value;
            var authCodeUrl = _configuration.GetSection("authCodeUrl").Value;
            var apiKey = _configuration.GetSection("apiKey").Value;
            var apiSecret = _configuration.GetSection("apiSecret").Value;
            var redirectUrl = _configuration.GetSection("redirectUrl").Value;

            var linkedInLoginUrl = string.Format(Constants.LinkedInAccessTokenUrl, apiBaseUrl, authCodeUrl, authRequest.AuthCode, redirectUrl, apiKey, apiSecret);

            var response = await _httpService.Get(linkedInLoginUrl);

            return response;
        }

        #endregion

        #region private methods

        #endregion

    }
}
