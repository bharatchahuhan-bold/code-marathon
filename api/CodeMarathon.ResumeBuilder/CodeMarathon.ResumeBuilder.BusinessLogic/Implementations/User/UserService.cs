using CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.Authentication;
using CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.User;
using CodeMarathon.ResumeBuilder.Common;
using CodeMarathon.ResumeBuilder.Common.HttpClientService;
using CodeMarathon.ResumeBuilder.DTOs.Authentication;
using CodeMarathon.ResumeBuilder.DTOs.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMarathon.ResumeBuilder.BusinessLogic.Implementations.User
{
    public class UserService : IUserService
    {
        #region private properties

        private HttpService _httpService;
        private IAuthenticationService _authService;

        #endregion

        #region constructors and desctructors
        public UserService(HttpService httpService,
            IAuthenticationService authService)
        {
            _httpService = httpService;
            _authService = authService;
        }

        #endregion

        #region local constants

        #endregion

        #region public methods

        public async Task<UserDetailsResponse> GetUserDetailsByLinkedInToken(string authCode)
        {
            var accessToken = await _authService.SignInWithLinkedIn(new DTOs.Authentication.AuthenticationRequest() { AuthCode = authCode });

            var accessTokenObj = JsonConvert.DeserializeObject<LinkedInAccessTokenResponse>(accessToken);

            var authorizationHeader = new Dictionary<string, string>();
            authorizationHeader.Add("Authorization", $"Bearer {accessTokenObj.access_token}");
            var response = await _httpService.Get(Constants.LinkedInProfileDetailsUrl, authorizationHeader);
            var linkedInUserDetails = JsonConvert.DeserializeObject<LinkedInUserDetailsResponse>(response);

            var userDetails = new UserDetailsResponse();

            userDetails.firstName = linkedInUserDetails.localizedFirstName;
            userDetails.lastName = linkedInUserDetails.localizedLastName;
            userDetails.profilePictureUrl = linkedInUserDetails.profilePicture.displayImage;

            // Add mock data
            userDetails.address = new Address();
            userDetails.address.addressLine1 = "2029 Stierlin Ct";
            userDetails.address.addressLine2 = "Mountain View";
            userDetails.address.city = "San Jose";
            userDetails.address.state = "California";
            userDetails.address.country = "United States Of America";
            userDetails.address.zipCode = "94043";

            userDetails.birthDate = DateTime.Now.AddYears(-27);

            userDetails.cerfications = new Cerfications()
            {
                company = "BOLD",
                id = 1234,
                endMonthYear = DateTime.Now.AddMonths(-10),
                name = "Azure AZ-204 Certification",
                startMonthYear = DateTime.Now.AddMonths(-12)
            };

            userDetails.education = new List<Education>();
            userDetails.education.Add(new Education()
            {
                degreeName = "B.Tech, Computer Science",
                endMonthYear = "2021-10-10",
                startMonthYear = "2017-10-10",
                schoolName = "Indian Institute of Technology, Bombay"
            });

            userDetails.organizations = new List<Organization>();
            userDetails.organizations.Add(new Organization
            {
                description = "Working as a senior software engineer at BOLD",
                endMonthYear = "2022-10-10",
                startMonthYear = "2021-10-10",
                name = "BOLD",
                occupation = "Service",
                position = "Senior Software Engineer"
            });

            userDetails.projects = new List<Project>();
            userDetails.projects.Add(new Project
            {
                description = "IOT based smart home assistant for many daily household work",
                endMonthYear = "2022-08-10",
                startMonthYear = "2022-09-10",
                title="Smart Home Assistant"
            });

            return userDetails;
        }

        #endregion

        #region private methods

        #endregion
    }
}
