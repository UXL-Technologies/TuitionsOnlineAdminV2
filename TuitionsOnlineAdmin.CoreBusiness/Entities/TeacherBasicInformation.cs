using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities

{
    public partial class TeacherBasicInformation
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public long ContactTelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public bool Active { get; set; }
        public string Qualifications { get; set; }
        public string TeachingInterests { get; set; }
        public string SellingPoint { get; set; }
        public string PricingStructure { get; set; }
        public string TeachingExperience { get; set; }
        public string PreferredLanguage { get; set; }
        public string AlternativeLanguage { get; set; }
        public string Schedule { get; set; }
    }
}
