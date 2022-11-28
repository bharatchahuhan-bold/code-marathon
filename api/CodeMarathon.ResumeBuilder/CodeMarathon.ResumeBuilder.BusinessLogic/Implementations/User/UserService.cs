using CodeMarathon.ResumeBuilder.BusinessLogic.Interfaces.User;
using CodeMarathon.ResumeBuilder.Common;
using CodeMarathon.ResumeBuilder.Common.HttpClientService;
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

        #endregion

        #region constructors and desctructors
        public UserService(HttpService httpService)
        {
            _httpService = httpService;
        }

        #endregion

        #region local constants

        #endregion

        #region public methods

        public async Task<UserDetailsResponse> GetUserDetailsByLinkedInToken(string token)
        {
            var authorizationHeader = new Dictionary<string, string>();
            authorizationHeader.Add("Authorization", token);
            var response = await _httpService.Get(Constants.LinkedInProfileDetailsUrl, authorizationHeader);
            var userDetails = JsonConvert.DeserializeObject<UserDetailsResponse>(response);

            // Add mock data
            userDetails.address = new Address();
            userDetails.address.localized = new Localized();
            userDetails.address.localized.en_US = "2029 Stierlin Ct, Mountain View, CA 94043";
            userDetails.address.preferredLocale=new PreferredLocale();
            userDetails.address.preferredLocale.country = "US";
            userDetails.address.preferredLocale.language = "en";

            userDetails.birthDate = new BirthDate();
            userDetails.birthDate.day = 1;
            userDetails.birthDate.month = 10;
            userDetails.birthDate.year = 1994;

            userDetails.cerfications = new Cerfications()
            {
                company = "BOLD",
                id = 1234,
                endMonthYear = new EndMonthYear()
                {
                    day = 1,
                    month = 10,
                    year = 2020
                },
                name = new Name()
                {
                    localized = new Localized()
                    {
                        en_US = "Azure AZ-204 Certification",
                    },
                    preferredLocale = new PreferredLocale { country = "US", language = "en" }
                },
                startMonthYear = new StartMonthYear()
                {
                    day = 1,
                    month = 10,
                    year = 2020
                }
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
