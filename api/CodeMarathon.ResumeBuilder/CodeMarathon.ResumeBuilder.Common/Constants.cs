using System;

namespace CodeMarathon.ResumeBuilder.Common
{
    public class ApiRoutes
    {
        public const string HealthStatusEndpoint = "Status";
        public const string AuthenticationEndpoint = "SignIn";
    }

    public class Constants 
    {
        public const string LinkedInAccessTokenUrl = "{0}{1}?grant_type=authorization_code&code={2}&redirect_uri={3}&client_id={4}&client_secret={5}";
        public const string LinkedInProfileDetailsUrl = "https://api.linkedin.com/v2/me";
    }

}
