using System;
using System.Collections.Generic;

namespace CodeMarathon.ResumeBuilder.DTOs.User
{
    public class Address
    {
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }
    }

    public class Cerfications
    {
        public int id { get; set; }
        public string company { get; set; }
        public DateTime endMonthYear { get; set; }
        public string name { get; set; }
        public DateTime startMonthYear { get; set; }
    }

    public class Education
    {
        public int id { get; set; }
        public string degreeName { get; set; }
        public string endMonthYear { get; set; }
        public string startMonthYear { get; set; }
        public string schoolName { get; set; }
    }

    public class EndMonthYear
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }

    public class FirstName
    {
        public Localized localized { get; set; }
        public PreferredLocale preferredLocale { get; set; }
    }

    public class LastName
    {
        public Localized localized { get; set; }
        public PreferredLocale preferredLocale { get; set; }
    }

    public class Localized
    {
        public string en_US { get; set; }
    }

    public class Name
    {
        public Localized localized { get; set; }
        public PreferredLocale preferredLocale { get; set; }
    }

    public class Organization
    {
        public int id { get; set; }
        public string description { get; set; }
        public string endMonthYear { get; set; }
        public string startMonthYear { get; set; }
        public string name { get; set; }
        public string occupation { get; set; }
        public string position { get; set; }
    }

    public class PreferredLocale
    {
        public string country { get; set; }
        public string language { get; set; }
    }

    public class ProfilePicture
    {
        public string displayImage { get; set; }
    }

    public class Project
    {
        public int id { get; set; }
        public string description { get; set; }
        public string endMonthYear { get; set; }
        public string startMonthYear { get; set; }
        public string title { get; set; }
    }

    public class LinkedInUserDetailsResponse
    {
        public string localizedLastName { get; set; }
        public ProfilePicture profilePicture { get; set; }
        public FirstName firstName { get; set; }
        public LastName lastName { get; set; }
        public string id { get; set; }
        public string localizedFirstName { get; set; }
    }

    public class UserDetailsResponse
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string profilePictureUrl { get; set; }
        public Address address { get; set; }
        public DateTime birthDate { get; set; }
        public Cerfications cerfications { get; set; }
        public List<Education> education { get; set; }
        public List<Organization> organizations { get; set; }
        public List<Project> projects { get; set; }
    }

    public class StartMonthYear
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }
}
